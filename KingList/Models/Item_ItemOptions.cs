//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KingList.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item_ItemOptions
    {
        public decimal ItemID { get; set; }
        public decimal ItemOptionID { get; set; }
        public string Value { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual ItemOptions ItemOptions { get; set; }
    }
}
