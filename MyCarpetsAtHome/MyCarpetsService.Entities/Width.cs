//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace MyCarpetsService.Entities
{
    public partial class Width
    {
        #region Primitive Properties
    
        public virtual int Id
        {
            get;
            set;
        }
    
        public virtual int ProductId
        {
            get;
            set;
        }
    
        public virtual int TypeId
        {
            get { return _typeId; }
            set
            {
                if (_typeId != value)
                {
                    if (Lookup != null && Lookup.Id != value)
                    {
                        Lookup = null;
                    }
                    _typeId = value;
                }
            }
        }
        private int _typeId;

        #endregion

        #region Navigation Properties
    
        public virtual Lookup Lookup
        {
            get { return _lookup; }
            set
            {
                if (!ReferenceEquals(_lookup, value))
                {
                    var previousValue = _lookup;
                    _lookup = value;
                    FixupLookup(previousValue);
                }
            }
        }
        private Lookup _lookup;

        #endregion

        #region Association Fixup
    
        private void FixupLookup(Lookup previousValue)
        {
            if (Lookup != null)
            {
                if (TypeId != Lookup.Id)
                {
                    TypeId = Lookup.Id;
                }
            }
        }

        #endregion

    }
}
