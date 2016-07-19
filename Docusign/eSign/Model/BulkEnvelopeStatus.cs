using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class BulkEnvelopeStatus : IEquatable<BulkEnvelopeStatus>
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="batchSize", EmitDefaultValue=false)]
        public string BatchSize { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="bulkEnvelopesBatchUri", EmitDefaultValue=false)]
        public string BulkEnvelopesBatchUri { get; set; }
  
        
        /// <summary>
        /// Entries with a failed status.
        /// </summary>
        /// <value>Entries with a failed status.</value>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public string Failed { get; set; }
  
        
        /// <summary>
        /// Retrieves entries with a status of queued.
        /// </summary>
        /// <value>Retrieves entries with a status of queued.</value>
        [DataMember(Name="queued", EmitDefaultValue=false)]
        public string Queued { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sent", EmitDefaultValue=false)]
        public string Sent { get; set; }
  
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="submittedDate", EmitDefaultValue=false)]
        public string SubmittedDate { get; set; }
  
        
        /// <summary>
        /// The number of results returned in this response.
        /// </summary>
        /// <value>The number of results returned in this response.</value>
        [DataMember(Name="resultSetSize", EmitDefaultValue=false)]
        public string ResultSetSize { get; set; }
  
        
        /// <summary>
        /// Starting position of the current result set.
        /// </summary>
        /// <value>Starting position of the current result set.</value>
        [DataMember(Name="startPosition", EmitDefaultValue=false)]
        public string StartPosition { get; set; }
  
        
        /// <summary>
        /// The last position in the result set.
        /// </summary>
        /// <value>The last position in the result set.</value>
        [DataMember(Name="endPosition", EmitDefaultValue=false)]
        public string EndPosition { get; set; }
  
        
        /// <summary>
        /// The total number of items available in the result set. This will always be greater than or equal to the value of the `resultSetSize` property.
        /// </summary>
        /// <value>The total number of items available in the result set. This will always be greater than or equal to the value of the `resultSetSize` property.</value>
        [DataMember(Name="totalSetSize", EmitDefaultValue=false)]
        public string TotalSetSize { get; set; }
  
        
        /// <summary>
        /// The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null.
        /// </summary>
        /// <value>The URI to the next chunk of records based on the search request. If the endPosition is the entire results of the search, this is null.</value>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }
  
        
        /// <summary>
        /// The postal code for the billing address.
        /// </summary>
        /// <value>The postal code for the billing address.</value>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }
  
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="bulkEnvelopes", EmitDefaultValue=false)]
        public List<BulkEnvelope> BulkEnvelopes { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkEnvelopeStatus {\n");
            sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  BulkEnvelopesBatchUri: ").Append(BulkEnvelopesBatchUri).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Queued: ").Append(Queued).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
            sb.Append("  ResultSetSize: ").Append(ResultSetSize).Append("\n");
            sb.Append("  StartPosition: ").Append(StartPosition).Append("\n");
            sb.Append("  EndPosition: ").Append(EndPosition).Append("\n");
            sb.Append("  TotalSetSize: ").Append(TotalSetSize).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  BulkEnvelopes: ").Append(BulkEnvelopes).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BulkEnvelopeStatus);
        }

        /// <summary>
        /// Returns true if BulkEnvelopeStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkEnvelopeStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkEnvelopeStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BatchSize == other.BatchSize ||
                    this.BatchSize != null &&
                    this.BatchSize.Equals(other.BatchSize)
                ) && 
                (
                    this.BatchId == other.BatchId ||
                    this.BatchId != null &&
                    this.BatchId.Equals(other.BatchId)
                ) && 
                (
                    this.BulkEnvelopesBatchUri == other.BulkEnvelopesBatchUri ||
                    this.BulkEnvelopesBatchUri != null &&
                    this.BulkEnvelopesBatchUri.Equals(other.BulkEnvelopesBatchUri)
                ) && 
                (
                    this.Failed == other.Failed ||
                    this.Failed != null &&
                    this.Failed.Equals(other.Failed)
                ) && 
                (
                    this.Queued == other.Queued ||
                    this.Queued != null &&
                    this.Queued.Equals(other.Queued)
                ) && 
                (
                    this.Sent == other.Sent ||
                    this.Sent != null &&
                    this.Sent.Equals(other.Sent)
                ) && 
                (
                    this.SubmittedDate == other.SubmittedDate ||
                    this.SubmittedDate != null &&
                    this.SubmittedDate.Equals(other.SubmittedDate)
                ) && 
                (
                    this.ResultSetSize == other.ResultSetSize ||
                    this.ResultSetSize != null &&
                    this.ResultSetSize.Equals(other.ResultSetSize)
                ) && 
                (
                    this.StartPosition == other.StartPosition ||
                    this.StartPosition != null &&
                    this.StartPosition.Equals(other.StartPosition)
                ) && 
                (
                    this.EndPosition == other.EndPosition ||
                    this.EndPosition != null &&
                    this.EndPosition.Equals(other.EndPosition)
                ) && 
                (
                    this.TotalSetSize == other.TotalSetSize ||
                    this.TotalSetSize != null &&
                    this.TotalSetSize.Equals(other.TotalSetSize)
                ) && 
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) && 
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
                ) && 
                (
                    this.BulkEnvelopes == other.BulkEnvelopes ||
                    this.BulkEnvelopes != null &&
                    this.BulkEnvelopes.SequenceEqual(other.BulkEnvelopes)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.BatchSize != null)
                    hash = hash * 57 + this.BatchSize.GetHashCode();
                
                if (this.BatchId != null)
                    hash = hash * 57 + this.BatchId.GetHashCode();
                
                if (this.BulkEnvelopesBatchUri != null)
                    hash = hash * 57 + this.BulkEnvelopesBatchUri.GetHashCode();
                
                if (this.Failed != null)
                    hash = hash * 57 + this.Failed.GetHashCode();
                
                if (this.Queued != null)
                    hash = hash * 57 + this.Queued.GetHashCode();
                
                if (this.Sent != null)
                    hash = hash * 57 + this.Sent.GetHashCode();
                
                if (this.SubmittedDate != null)
                    hash = hash * 57 + this.SubmittedDate.GetHashCode();
                
                if (this.ResultSetSize != null)
                    hash = hash * 57 + this.ResultSetSize.GetHashCode();
                
                if (this.StartPosition != null)
                    hash = hash * 57 + this.StartPosition.GetHashCode();
                
                if (this.EndPosition != null)
                    hash = hash * 57 + this.EndPosition.GetHashCode();
                
                if (this.TotalSetSize != null)
                    hash = hash * 57 + this.TotalSetSize.GetHashCode();
                
                if (this.NextUri != null)
                    hash = hash * 57 + this.NextUri.GetHashCode();
                
                if (this.PreviousUri != null)
                    hash = hash * 57 + this.PreviousUri.GetHashCode();
                
                if (this.BulkEnvelopes != null)
                    hash = hash * 57 + this.BulkEnvelopes.GetHashCode();
                
                return hash;
            }
        }

    }
}
