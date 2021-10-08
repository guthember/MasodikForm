using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MasodikForm
{
  public partial class Form1 : Form
  {
    int hibazik = 0;
    List<string> uzenetek = new List<string>();

    public Form1()
    {
      InitializeComponent();
      Beolvasas();
    }

    private void Beolvasas()
    {
      StreamReader be = new StreamReader("hiba.txt");
      while (!be.EndOfStream)
      {
        uzenetek.Add(be.ReadLine());
      }
      be.Close();
    }

    private void btnKilepes_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      tbBevitel.Focus();
      lblEredmeny.Text = "";
      MessageBox.Show("3-szor hibázhatsz!", "Hibák száma", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnSzamol_Click(object sender, EventArgs e)
    {
      if (tbBevitel.Text == "")
      {
        MessageBox.Show(Uzenet(),"Ez hiba",MessageBoxButtons.OK,MessageBoxIcon.Warning);
      }
      else
      {
        try
        {
          int szam = Convert.ToInt32(tbBevitel.Text);
          lblEredmeny.Text = $"A szám kétszerese: {2 * szam}";
          lbUzenetek.Items.Add($"A szám kétszerese: {2 * szam}");
          tbBevitel.Text = "";
          tbBevitel.Focus();
          hibazik = 0;
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message+$"\nEz nem jó: {tbBevitel.Text}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
          lbUzenetek.Items.Add($"Ez nem jó: {tbBevitel.Text}");
          tbBevitel.Text = "";
          tbBevitel.Focus();
          hibazik++;
          lbUzenetek.Items.Add($"Hibák száma: {hibazik}");
          if (hibazik == 3)
          {
            MessageBox.Show("Pápá");
            Application.Exit();
          }
        }
      }
    }

    private string Uzenet()
    {
      int max = uzenetek.Count;
      Random vel = new Random(Guid.NewGuid().GetHashCode());
      return uzenetek[vel.Next(0,max)];
    }
  }
}
