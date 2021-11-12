using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Windows.Forms;
namespace BUS
{
    public class ChiTietTourBUS
    {
        public void List(DataGridView data,string id)
        {
            data.DataSource = new ChiTietTourDAO().ListSearch(id);
        }
        public void ListSearch(DataGridView data, TextBox text)
        {
            data.DataSource = new ChiTietTourDAO().ListSearch(text.Text.ToString());
        }
        public void get(string id, TextBox num1, TextBox num2, TextBox num3)
        {
            List<string> get = new List<string>();
            ChiTietTourDTO tour = new ChiTietTourDAO().get(id);
            num1.Text = tour.Id_Tour;
            num2.Text = tour.Id_DiaDiem;
            num3.Text = tour.Thutu.ToString();
        }
        public bool Update(string matour, string madiadiem, int thutu)
        {
            ChiTietTourDTO tour = new ChiTietTourDTO(matour, madiadiem, thutu);
            return new ChiTietTourDAO().Update(matour,tour);
            //
        }

        public bool Insert(string matour, string madiadiem, int thutu)
        {
            ChiTietTourDTO tour = new ChiTietTourDTO(matour, madiadiem, thutu);
            return new ChiTietTourDAO().Insert(tour);
            //Hung
        }
        public bool Delete(string data)
        {
            return new ChiTietTourDAO().Delete(data);
        }
    }
}
