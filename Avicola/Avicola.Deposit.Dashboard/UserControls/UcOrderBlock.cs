using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Sales.Entities;
using Avicola.Sales.Services.Dtos;

namespace Avicola.Deposit.Dashboard.UserControls
{
    public partial class UcOrderBlock : UserControl
    {
        #region Properties

        public DateTime? CreatedDate { get; set; }
        public string Status { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }

        public List<OrderEggClassDto> EggClasses { get; set; }
        public List<EggClassStock> CurrentStocks { get; set; }

        #endregion
        

        public UcOrderBlock()
        {
            InitializeComponent();
        }

        private void UcOrderBlock_Load(object sender, EventArgs e)
        {
            lblCreatedDateValue.Text = CreatedDate.GetValueOrDefault().ToShortDateString();
            lblStatusValue.Text = Status;
            lblClientNameValue.Text = ClientName;
            lblAddressValue.Text = Address;
            LoadEggClasses();
        }

        private void LoadEggClasses()
        {
            var completed = true;
            foreach (var dto in EggClasses)
            {
                var currentStock = CurrentStocks.FirstOrDefault(x => x.Id == dto.EggClassId).EggsCount.GetValueOrDefault();
                var uc = new UcEggClassOrder()
                {
                    EggClassName = dto.EggClassName,
                    Amount = dto.Dozens,
                    CurrentStock = currentStock
                };
                flpOrderEggClasses.Controls.Add(uc);

                if (completed && Convert.ToDecimal(currentStock) / 12 < dto.Dozens)
                    completed = false;
            }

            if (completed)
            {
                this.BackColor = Color.FromArgb(255, 196, 255, 178);
            }
        }
    }
}
