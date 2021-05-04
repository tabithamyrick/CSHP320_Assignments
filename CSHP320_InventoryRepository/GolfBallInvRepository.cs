using CSHP320_InventoryProjectDB;
using System.Collections.Generic;
using System.Linq;

namespace CSHP320_InventoryRepository
{
    public class GolfBallInvModel
    {

    }
    class GolfBallInvRepository
    {
        public GolfBallInvModel Add(GolfBallInvModel golfBallInvModel)
        {
            var contactDb = ToDbModel(golfBallInvModel);

            DatabaseManager.Instance.Contact.Add(contactDb);
            DatabaseManager.Instance.SaveChanges();

            golfBallInvModel = new GolfBallInvModel
            {
                Age = contactDb.ContactAge,
                CreatedDate = contactDb.ContactCreatedDate,
                Email = contactDb.ContactEmail,
                Id = contactDb.ContactId,
                Name = contactDb.ContactName,
                Notes = contactDb.ContactNotes,
                PhoneNumber = contactDb.ContactPhoneNumber,
                PhoneType = contactDb.ContactPhoneType
            };
            return golfBallInvModel;
        }
        public List<GolfBallInvModel> GetAll()
        {
            // Use .Select() to map the database contacts to GolfBallInvModel
            var items = DatabaseManager.Instance.Database
              .Select(t => new GolfBallInvModel
              {
                  Age = t.ContactAge,
                  CreatedDate = t.ContactCreatedDate,
                  Email = t.ContactEmail,
                  Id = t.ContactId,
                  Name = t.ContactName,
                  Notes = t.ContactNotes,
                  PhoneNumber = t.ContactPhoneNumber,
                  PhoneType = t.ContactPhoneType,
              }).ToList();

            return items;
        }

        public bool Update(GolfBallInvModel golfBallInvModel)
        {
            var original = DatabaseManager.Instance.Contact.Find(golfBallInvModel.Id);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDbModel(golfBallInvModel));
                DatabaseManager.Instance.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Remove(int contactId)
        {
            var items = DatabaseManager.Instance.Contact
                                .Where(t => t.ContactId == contactId);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.Contact.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        private Contact ToDbModel(GolfBallInvModel golfBallInvModel)
        {
            var contactDb = new Contact
            {
                ContactAge = golfBallInvModel.Age,
                ContactCreatedDate = golfBallInvModel.CreatedDate,
                ContactEmail = golfBallInvModel.Email,
                ContactId = golfBallInvModel.Id,
                ContactName = golfBallInvModel.Name,
                ContactNotes = golfBallInvModel.Notes,
                ContactPhoneNumber = golfBallInvModel.PhoneNumber,
                ContactPhoneType = golfBallInvModel.PhoneType,
            };

            return contactDb;
        }
    }
}
}
