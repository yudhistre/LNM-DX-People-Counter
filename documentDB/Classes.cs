using System.Collections.Generic;

namespace documentDB.Classes
{
    public class genericDocument
    {
        public string id { get; set; } // Assigned ID 
        public string _rid { get; set; } // Auto Generated ID 
    }

    public class genericDocumentsCollection
    {
        public string _rid { get; set; } //Auto Generated ID
        public List<genericDocument> Documents { get; set; } // List of documents in the collection
        public int _count { get; set; } // Number of documents within the collection

    }
}
