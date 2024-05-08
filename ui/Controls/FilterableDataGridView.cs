using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UI.Controls
{
    public class FilterableDataGridView : UserControl
    {
        public delegate void ActionHandler(int rowIndex, DataGridViewRow rowData);

        private BindingSource _bindingSource;
        private DataGridView _dataGridView;
        private TextBox _textBoxFilter;

        public FilterableDataGridView()
        {
            InitializeComponents();
            SetupDataGridView();
        }

        public DataTable DataSource
        {
            get => (DataTable)_bindingSource.DataSource;
            set
            {
                _bindingSource.DataSource = value;
                _dataGridView.DataSource = _bindingSource;
            }
        }

        public DataGridViewColumnCollection Columns => _dataGridView.Columns;

        public event ActionHandler EditClicked;
        public event ActionHandler DeleteClicked;

        private void InitializeComponents()
        {
            _dataGridView = new DataGridView { Dock = DockStyle.Fill };
            _textBoxFilter = new TextBox { Dock = DockStyle.Top };
            _bindingSource = new BindingSource();

            _dataGridView.AllowUserToAddRows = false;
            _dataGridView.AllowUserToDeleteRows = false;
            _dataGridView.AllowUserToOrderColumns = true;
            _dataGridView.AllowUserToResizeColumns = false;
            _dataGridView.AllowUserToResizeRows = false;
            _dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dataGridView.ReadOnly = true;
            _dataGridView.MultiSelect = false;
            _dataGridView.RowHeadersVisible = false;

            _dataGridView.CellClick += DataGridView_CellClick;
            _dataGridView.DataBindingComplete += DataGridView_DataBindingComplete;

            _textBoxFilter.TextChanged += TextBoxFilter_TextChanged;

            Controls.Add(_dataGridView);
            Controls.Add(_textBoxFilter);
        }

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var dataIndex = 0;

            foreach (DataColumn column in ((DataTable)_bindingSource.DataSource).Columns)
            {
                _dataGridView.Columns[column.ColumnName].DisplayIndex = dataIndex++;
            }

            _dataGridView.Columns["Edit"].DisplayIndex = dataIndex++;
            _dataGridView.Columns["Delete"].DisplayIndex = dataIndex;
        }

        private void SetupDataGridView()
        {
            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Name = "Edit"
            };

            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "Delete",
                UseColumnTextForButtonValue = true
            };

            _dataGridView.Columns.Add(editButton);
            _dataGridView.Columns.Add(deleteButton);
        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_textBoxFilter.Text))
            {
                _bindingSource.Filter = string.Empty;
            }
            else
            {
                var filter = new StringBuilder();
                var safeFilterText = _textBoxFilter.Text.Replace("'", "''");

                var isFirst = true;

                foreach (DataGridViewColumn col in _dataGridView.Columns)
                {
                    if (col.ValueType != typeof(string) && col.ValueType != typeof(int) &&
                        col.ValueType != typeof(decimal) && col.ValueType != typeof(DateTime))
                    {
                        continue;
                    }

                    if (!isFirst)
                    {
                        filter.Append(" OR ");
                    }

                    filter.Append($"Convert([{col.Name}], 'System.String') LIKE '%{safeFilterText}%'");
                    isFirst = false;
                }

                _bindingSource.Filter = filter.ToString();
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var rowData = _dataGridView.Rows[e.RowIndex];

            if (e.ColumnIndex == _dataGridView.Columns["Edit"].Index)
            {
                EditClicked?.Invoke(e.RowIndex, rowData);
            }
            else if (e.ColumnIndex == _dataGridView.Columns["Delete"].Index)
            {
                DeleteClicked?.Invoke(e.RowIndex, rowData);
            }
        }
    }
}