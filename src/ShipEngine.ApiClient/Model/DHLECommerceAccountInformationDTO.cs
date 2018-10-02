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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ShipEngine.ApiClient.Client.SwaggerDateConverter;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    /// DHLECommerceAccountInformationDTO
    /// </summary>
    [DataContract]
    public partial class DHLECommerceAccountInformationDTO :  IEquatable<DHLECommerceAccountInformationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DHLECommerceAccountInformationDTO" /> class.
        /// </summary>
        /// <param name="nickname">nickname.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="pickupNumber">pickupNumber.</param>
        /// <param name="ftpUsername">ftpUsername.</param>
        /// <param name="ftpPassword">ftpPassword.</param>
        public DHLECommerceAccountInformationDTO(string nickname = default(string), string accountNumber = default(string), string pickupNumber = default(string), string ftpUsername = default(string), string ftpPassword = default(string))
        {
            this.Nickname = nickname;
            this.AccountNumber = accountNumber;
            this.PickupNumber = pickupNumber;
            this.FtpUsername = ftpUsername;
            this.FtpPassword = ftpPassword;
        }
        
        /// <summary>
        /// Gets or Sets Nickname
        /// </summary>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="account_number", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets PickupNumber
        /// </summary>
        [DataMember(Name="pickup_number", EmitDefaultValue=false)]
        public string PickupNumber { get; set; }

        /// <summary>
        /// Gets or Sets FtpUsername
        /// </summary>
        [DataMember(Name="ftp_username", EmitDefaultValue=false)]
        public string FtpUsername { get; set; }

        /// <summary>
        /// Gets or Sets FtpPassword
        /// </summary>
        [DataMember(Name="ftp_password", EmitDefaultValue=false)]
        public string FtpPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DHLECommerceAccountInformationDTO {\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  PickupNumber: ").Append(PickupNumber).Append("\n");
            sb.Append("  FtpUsername: ").Append(FtpUsername).Append("\n");
            sb.Append("  FtpPassword: ").Append(FtpPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DHLECommerceAccountInformationDTO);
        }

        /// <summary>
        /// Returns true if DHLECommerceAccountInformationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DHLECommerceAccountInformationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DHLECommerceAccountInformationDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.PickupNumber == input.PickupNumber ||
                    (this.PickupNumber != null &&
                    this.PickupNumber.Equals(input.PickupNumber))
                ) && 
                (
                    this.FtpUsername == input.FtpUsername ||
                    (this.FtpUsername != null &&
                    this.FtpUsername.Equals(input.FtpUsername))
                ) && 
                (
                    this.FtpPassword == input.FtpPassword ||
                    (this.FtpPassword != null &&
                    this.FtpPassword.Equals(input.FtpPassword))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.PickupNumber != null)
                    hashCode = hashCode * 59 + this.PickupNumber.GetHashCode();
                if (this.FtpUsername != null)
                    hashCode = hashCode * 59 + this.FtpUsername.GetHashCode();
                if (this.FtpPassword != null)
                    hashCode = hashCode * 59 + this.FtpPassword.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
