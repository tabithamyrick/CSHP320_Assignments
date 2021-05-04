using CSHP320_InventoryManagementProject;
using CSHP320_InventoryProjectDB;

namespace CSHP320_InventoryRepository
{
    public class DatabaseManager
    {

        private static readonly GolfballInvDBContext entities;

        static DatabaseManager()
        {
            entities = new GolfballInvDBContext();
        }

        public static GolfballInvDBContext Instance
        {
            get
            {
                return entities;
            }
        }

    }
}
