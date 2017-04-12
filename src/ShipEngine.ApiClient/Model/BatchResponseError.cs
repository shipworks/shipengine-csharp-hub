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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    ///     BatchResponseError
    /// </summary>
    [DataContract]
    public class BatchResponseError : IEquatable<BatchResponseError>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BatchResponseError" /> class.
        /// </summary>
        /// <param name="error">Error.</param>
        /// <param name="shipmentId">ShipmentId.</param>
        public BatchResponseError(string error = default(string), string shipmentId = default(string))
        {
            Error = error;
            ShipmentId = shipmentId;
        }

        /// <summary>
        ///     Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        ///     Gets or Sets ShipmentId
        /// </summary>
        [DataMember(Name = "shipment_id", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        ///     Returns true if BatchResponseError instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchResponseError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchResponseError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
            {
                return false;
            }

            return
                (
                    Error == other.Error ||
                    Error != null &&
                    Error.Equals(other.Error)
                ) &&
                (
                    ShipmentId == other.ShipmentId ||
                    ShipmentId != null &&
                    ShipmentId.Equals(other.ShipmentId)
                );
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
            sb.Append("class BatchResponseError {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
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
            return Equals(obj as BatchResponseError);
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
                if (Error != null)
                {
                    hash = hash * 59 + Error.GetHashCode();
                }
                if (ShipmentId != null)
                {
                    hash = hash * 59 + ShipmentId.GetHashCode();
                }
                return hash;
            }
        }
    }
}