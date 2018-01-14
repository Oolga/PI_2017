using lab_39.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab_39.Services
{
    public class PhoneService
    {
        Model db;

        public Item GetItemById(int id)
        {
            return db.Items.Find(id);
        }

        public IEnumerable<Item> GetPhones() {

            return db.Items.ToList();
        }

        public PhoneService() {
            db = new Model();
        }

        public void Insert(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id) {
            var deletedItem = db.Items.Where(x => x.Id == id).FirstOrDefault();
            db.Items.Remove(deletedItem);
            db.SaveChanges();
        }

        public void Update(Item item) {

            db.Items.Attach(item);
            db.Entry(item).State = EntityState.Modified;
            // var updatedItem = db.Items.Where(x => x.Id == item.Id).FirstOrDefault();
            // updatedItem = item;
             db.SaveChanges();
        }
    }
}