//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Weapons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Weapons()
        {
            this.HeroWeapon = new HashSet<HeroWeapon>();
        }
    
        public int Id { get; set; }
        public Nullable<int> WeaponType { get; set; }
        public Nullable<decimal> PriceOfBuy { get; set; }
        public Nullable<int> WeaponAccessLevel { get; set; }
        public Nullable<decimal> WeaponWeight { get; set; }
        public string Characteristics { get; set; }
        public Nullable<int> CombatPower { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HeroWeapon> HeroWeapon { get; set; }
        public virtual WeaponsType WeaponsType { get; set; }
    }
}
