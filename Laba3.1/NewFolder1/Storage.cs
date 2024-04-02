using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Policy;
using System.Web;


namespace Laba3._1.NewFolder1
{
    public class Storage
    {
        public List<Smartphone> phones = new List<Smartphone>();

        public void AddPhone(Smartphone phone)
        {
            phones.Add(phone);
        }

        public Smartphone FindPhoneByModel(string model)
        {
            return phones.Find(phone => phone.Model == model);
        }
        public List<Smartphone> FindPhonesByDisplaySize(double displaySize)
        {
            return phones.FindAll(phone => phone.DisplaySize == displaySize);
        }

        public List<Smartphone> FindPhonesByPriceRange(decimal minPrice, decimal maxPrice)
        {
            return phones.FindAll(phone => phone.Price >= minPrice && phone.Price <= maxPrice);
        }

        public int CountTotalPhones()
        {
            return phones.Count;
        }
        public Smartphone FindPhoneByManufacturer(string manufacturer)
        {
            return phones.Find(phone => phone.Manufacturer == manufacturer);
        }

        public void SortPhonesByModel()
        {
            phones.Sort((x, y) => x.Model.CompareTo(y.Model));
        }

        public void SortPhonesByManufacturer()
        {
            phones.Sort((x, y) => x.Manufacturer.CompareTo(y.Manufacturer));
        }

        public void SortPhonesByDisplaySize()
        {
            phones.Sort((x, y) => x.DisplaySize.CompareTo(y.DisplaySize));
        }
        public Smartphone this[int index]
        {
            get { return phones[index]; }
        }
    }
}
