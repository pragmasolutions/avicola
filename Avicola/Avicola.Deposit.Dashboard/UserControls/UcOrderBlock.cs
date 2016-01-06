﻿using System;
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
using Framework.WinForm.Comun.Notification;
using Telerik.WinControls.UI;

namespace Avicola.Deposit.Dashboard.UserControls
{
    public partial class UcOrderBlock : UserControl
    {
        #region Properties

        public Guid OrderId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Status { get; set; }
        public Guid OrderStatusId { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }

        public List<OrderEggClassDto> EggClasses { get; set; }
        public List<EggClassStock> CurrentStocks { get; set; }

        public IMessageBoxDisplayService MessageBoxDisplayService { get; set; }

        #endregion


        public UcOrderBlock()
        {
            InitializeComponent();
        }

        public event EventHandler<Guid> OrderFinished;

        private void OnOrderFinished(Guid orderId)
        {
            if (OrderFinished != null)
            {
                OrderFinished(this, OrderId);
            }
        }

        private void UcOrderBlock_Load(object sender, EventArgs e)
        {
            lblCreatedDateValue.Text = CreatedDate.GetValueOrDefault().ToShortDateString();
            lblStatusValue.Text = Status;
            lblClientNameValue.Text = ClientName;
            lblAddressValue.Text = Address;
            LoadEggClasses();

            //
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

            if (flpOrderEggClasses.Controls.Count > 0)
            {
                flpOrderEggClasses.SetFlowBreak(flpOrderEggClasses.Controls[flpOrderEggClasses.Controls.Count - 1], true);
            }

            if (completed)
            {
                this.BackColor = Color.FromArgb(255, 196, 255, 178);
            }

            if (OrderStatusId == OrderStatus.IN_PROGESS)
            {
                RadButton btnFinishOrder = new RadButton();
                btnFinishOrder.Text = "Finalizar Pedído";
                btnFinishOrder.Click += btnFinishOrder_Click;
                btnFinishOrder.Anchor = AnchorStyles.Right;

                flpOrderEggClasses.Controls.Add(btnFinishOrder);
            }
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            MessageBoxDisplayService.ShowConfirmationDialog("¿Esta Seguro que desea finalizar este Pedído?", "Finalizar Pedído",
                () =>
                {
                    OnOrderFinished(OrderId);
                });
        }
    }
}
