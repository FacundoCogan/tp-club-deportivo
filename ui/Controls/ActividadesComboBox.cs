using System.ComponentModel;
using System.Windows.Forms;

namespace UI.Controls
{
    [DesignerCategory("Code")]
    [DesignTimeVisible(true)]
    [ToolboxItem(true)]
    public class ActividadesComboBox : ComboBox
    {
        // Parameterless constructor for design-time
        public ActividadesComboBox()
        {
            DisplayMember = "Nombre";
            DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}