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
    /// NewgisticsAccountInformationDTO
    /// </summary>
    [DataContract]
    public partial class NewgisticsAccountInformationDTO :  IEquatable<NewgisticsAccountInformationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewgisticsAccountInformationDTO" /> class.
        /// </summary>
        /// <param name="merchantId">merchantId.</param>
        /// <param name="mailerId">mailerId.</param>
        /// <param name="inductionSite">inductionSite.</param>
        /// <param name="nickname">nickname.</param>
        public NewgisticsAccountInformationDTO(int? merchantId = default(int?), int? mailerId = default(int?), string inductionSite = default(string), string nickname = default(string))
        {
            this.MerchantId = merchantId;
            this.MailerId = mailerId;
            this.InductionSite = inductionSite;
            this.Nickname = nickname;
        }
        
        /// <summary>
        /// Gets or Sets MerchantId
        /// </summary>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public int? MerchantId { get; set; }

        /// <summary>
        /// Gets or Sets MailerId
        /// </summary>
        [DataMember(Name="mailer_id", EmitDefaultValue=false)]
        public int? MailerId { get; set; }

        /// <summary>
        /// Gets or Sets InductionSite
        /// </summary>
        [DataMember(Name="induction_site", EmitDefaultValue=false)]
        public string InductionSite { get; set; }

        /// <summary>
        /// Gets or Sets Nickname
        /// </summary>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewgisticsAccountInformationDTO {\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MailerId: ").Append(MailerId).Append("\n");
            sb.Append("  InductionSite: ").Append(InductionSite).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
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
            return this.Equals(input as NewgisticsAccountInformationDTO);
        }

        /// <summary>
        /// Returns true if NewgisticsAccountInformationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NewgisticsAccountInformationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewgisticsAccountInformationDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MailerId == input.MailerId ||
                    (this.MailerId != null &&
                    this.MailerId.Equals(input.MailerId))
                ) && 
                (
                    this.InductionSite == input.InductionSite ||
                    (this.InductionSite != null &&
                    this.InductionSite.Equals(input.InductionSite))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
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
                if (this.MerchantId != null)
                    hashCode = hashCode * 59 + this.MerchantId.GetHashCode();
                if (this.MailerId != null)
                    hashCode = hashCode * 59 + this.MailerId.GetHashCode();
                if (this.InductionSite != null)
                    hashCode = hashCode * 59 + this.InductionSite.GetHashCode();
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
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