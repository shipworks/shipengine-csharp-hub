/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    ///     WarehouseListDTO
    /// </summary>
    [DataContract]
    public class WarehouseListDTO : IEquatable<WarehouseListDTO>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WarehouseListDTO" /> class.
        /// </summary>
        /// <param name="warehouses">Warehouses.</param>
        public WarehouseListDTO(List<WarehouseDTO> warehouses = default(List<WarehouseDTO>))
        {
            Warehouses = warehouses;
        }

        /// <summary>
        ///     Gets or Sets Warehouses
        /// </summary>
        [DataMember(Name = "warehouses", EmitDefaultValue = false)]
        public List<WarehouseDTO> Warehouses { get; set; }

        /// <summary>
        ///     Returns true if WarehouseListDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of WarehouseListDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WarehouseListDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
            {
                return false;
            }

            return
                Warehouses == other.Warehouses ||
                Warehouses != null &&
                Warehouses.SequenceEqual(other.Warehouses);
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WarehouseListDTO {\n");
            sb.Append("  Warehouses: ").Append(Warehouses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as WarehouseListDTO);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (Warehouses != null)
                {
                    hash = hash * 59 + Warehouses.GetHashCode();
                }
                return hash;
            }
        }
    }
}