using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;
        
        public Menu(string foodName, int count, float price, float totalPrice)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
           
        }
        public Menu(DataRow row)
        {
            this.FoodName = row["name"]?.ToString() ?? string.Empty;
            this.Count = row["count"] != DBNull.Value ? Convert.ToInt32(row["count"]) : 0;
            this.Price = row["price"] != DBNull.Value ? Convert.ToSingle(row["price"]) : 0.0f;
            this.TotalPrice = row["totalPrice"] != DBNull.Value ? Convert.ToSingle(row["totalPrice"]) : 0.0f;
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
