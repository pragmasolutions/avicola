using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avicola.Office.Entities;
using Telerik.WinControls.UI;

namespace Avicola.Production.Win.UserControls
{
    public partial class UcStandardSelecction : UserControl
    {
        public const string StandardImagesBaseFolder = @"Resources\Images\Standards\{0}.png";

        public UcStandardSelecction()
        {
            InitializeComponent();
        }

        public event EventHandler<Standard> StandardSelected;
        public event EventHandler SilosEmptyingSelected;

        public List<Standard> Standards 
        {
            set
            {
                StandardButtonsPanel.Controls.Clear();

                var assemblyPath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                foreach (var standard in value)
                {
                    var radButton = new RadButton();

                    radButton.Text = standard.Name;
                    radButton.TextAlignment = ContentAlignment.BottomCenter;
                    radButton.ImageAlignment = ContentAlignment.MiddleCenter;
                    radButton.Width = 200;
                    radButton.Height = 200;

                    
                    if (assemblyPath != null)
                    {
                        string imagePath = Path.Combine(assemblyPath, string.Format(StandardImagesBaseFolder, standard.Name));

                        if (File.Exists(imagePath))
                        {
                            radButton.Image = Image.FromFile(imagePath);
                        }
                    }

                    radButton.Click += RadButtonOnClick;
                    radButton.Tag = standard;

                    StandardButtonsPanel.Controls.Add(radButton);
                }

                var siloButon = new RadButton
                {
                    Text = "Vaciamiento de Silos",
                    TextAlignment = ContentAlignment.BottomCenter,
                    ImageAlignment = ContentAlignment.MiddleCenter,
                    Width = 200,
                    Height = 200
                };

                if (assemblyPath != null)
                {
                    string imagePath = Path.Combine(assemblyPath, string.Format(StandardImagesBaseFolder, "Vaciamiento de Silos"));

                    if (File.Exists(imagePath))
                    {
                        siloButon.Image = Image.FromFile(imagePath);
                    }
                }

                siloButon.Click += SilosEmptying_Click;
                siloButon.Tag = siloButon;

                StandardButtonsPanel.Controls.Add(siloButon);
            } 
        }

        private void RadButtonOnClick(object sender, EventArgs eventArgs)
        {
            var radButton = sender as RadButton;

            if (radButton != null)
            {
                var standard = radButton.Tag as Standard;

                if (standard != null)
                {
                    OnStandardSelected(standard);
                }
            }
        }

        private void SilosEmptying_Click(object sender, EventArgs e)
        {
            if (SilosEmptyingSelected != null)
            {
                SilosEmptyingSelected(sender, e);
            }
        }

        private void OnStandardSelected(Standard standard)
        {
            if (StandardSelected != null)
            {
                StandardSelected(this, standard);
            }
        }
    }
}
