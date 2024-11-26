// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace PetStore.Models
{
    /// <summary> Paged response of Pet items. </summary>
    public partial class PetCollectionWithNextLink
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal PetCollectionWithNextLink(IEnumerable<Pet> value)
        {
            Value = value.ToList();
        }

        internal PetCollectionWithNextLink(IList<Pet> value, Uri nextLink, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Value = value;
            NextLink = nextLink;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The items on this page. </summary>
        public IList<Pet> Value { get; }

        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}