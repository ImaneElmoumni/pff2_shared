//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pff2
{
    using System;
    using System.Collections.Generic;
    
    public partial class AffectationFMG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AffectationFMG()
        {
            this.seances = new HashSet<seance>();
        }
    
        public string FormateurFK { get; set; }
        public int numModuleFk { get; set; }
        public string codeFFk1 { get; set; }
        public int codeGroupe { get; set; }
        public string codeEFPFK { get; set; }
        public string codeFFk2 { get; set; }
        public string annee { get; set; }
        public int niveau { get; set; }
        public int semestre { get; set; }
    
        public virtual formateur formateur { get; set; }
        public virtual groupe groupe { get; set; }
        public virtual module module { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seance> seances { get; set; }
    }
}
