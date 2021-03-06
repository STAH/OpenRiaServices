﻿using System.Diagnostics.CodeAnalysis;
using System.Globalization;
#if LINQTOSQL
using OpenRiaServices.DomainServices.LinqToSql;
#else
using OpenRiaServices.DomainServices.EntityFramework;
#endif


#if !DBCONTEXT
namespace System.ComponentModel.DataAnnotations.Schema
{
    /// <summary>
    ///   Annotates a CLR property with an associated database generation option.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    [SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Justification = "This attribute is inheritable by design, like other attributes in DataAnnotations.")]
    internal class DatabaseGeneratedAttribute : Attribute
    {
        private DatabaseGeneratedOption _databaseGeneratedOption;

        /// <summary>
        /// The constructor for the DatabaseGeneratedAttribute.
        /// </summary>
        /// <param name="databaseGeneratedOption">The <see cref="DatabaseGeneratedOption"/> indicating how the value was generated.</param>
        public DatabaseGeneratedAttribute(DatabaseGeneratedOption databaseGeneratedOption)
        {
            DatabaseGeneratedOption = databaseGeneratedOption;
        }

        /// <summary>
        ///   Determines how the associated property value will be
        ///   generated by the underlying database.
        /// </summary>
        public DatabaseGeneratedOption DatabaseGeneratedOption
        {
            get
            {
                if (!Enum.IsDefined(typeof(DatabaseGeneratedOption), this._databaseGeneratedOption))
                {
                    throw new InvalidOperationException(
                        string.Format(CultureInfo.InvariantCulture, Resource.DatabaseGeneratedOptionNotDefined, this._databaseGeneratedOption.ToString()));
                }
                return this._databaseGeneratedOption;
            }

            private set
            {
                this._databaseGeneratedOption = value;
            }
        }
    }
}
#endif