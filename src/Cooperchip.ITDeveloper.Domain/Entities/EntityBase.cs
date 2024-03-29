﻿using System;

namespace Cooperchip.ITDeveloper.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public override bool Equals(object obj)
        {
            var compareTo = obj as EntityBase;
            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;
            return base.Equals(obj);
        }

        public static bool operator ==(EntityBase a, EntityBase b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return a.Equals(b);
        }

        public static bool operator !=(EntityBase a, EntityBase b) => !(a == b);

        public override int GetHashCode() => (GetType().GetHashCode() * 13) + Id.GetHashCode();

        public override string ToString() => GetType().Name + " [Id=" + Id + "]";

    }
}
