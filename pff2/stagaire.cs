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
    
    public partial class stagaire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public stagaire()
        {
            this.Absences = new HashSet<Absence>();
            this.groupes = new HashSet<groupe>();
            this.groupes1 = new HashSet<groupe>();
        }
    
        public string cee { get; set; }
        public string cin { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public Nullable<System.DateTime> dateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public string codePostal { get; set; }
        public string region { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public string nomCompletTuteur { get; set; }
        public string lienParente { get; set; }
        public string GSMTuteur { get; set; }
        public Nullable<int> codegroupe { get; set; }
        public string codeeFPFK { get; set; }
        public string codefFk { get; set; }
        public string annee { get; set; }
        public Nullable<int> niveau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Absence> Absences { get; set; }
        public virtual groupe groupe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<groupe> groupes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<groupe> groupes1 { get; set; }
    }
}
