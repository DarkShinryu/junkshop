using System.Windows.Forms;

namespace JunkShop
{
    class NumericUpDownG : NumericUpDown
    {
        protected override void UpdateEditText()
        {
            this.Text = this.Value.ToString() + " G";
        }
    }
}
