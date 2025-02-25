using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

public class Form
{
    [Key]
    public int FormId { get; set; }

    public DateOnly ContractStartingDate { get; set; }

    public DateOnly ContractEndDate { get; set; }

    [MaxLength(30), AllowNull]
    public string DepartmentName { get; set; }

    [MaxLength(30), AllowNull]
    [Required(ErrorMessage = "Person Name is required.")]
    public string PersonName { get; set; }

    [MaxLength(30), AllowNull]
    public string RelevantDirectorName { get; set; }

    [MaxLength(30), AllowNull]
    public string IdentificationCode { get; set; }

    [MaxLength(30), AllowNull]
    public string SupplierMail { get; set; }

    [MaxLength(30), AllowNull]
    public string ContractType { get; set; }

    [MaxLength(30), AllowNull]
    public string Subject { get; set; }

    [MaxLength(30), AllowNull]
    public string Amount { get; set; }

    [MaxLength(30), AllowNull]
    public string Currency { get; set; }

    public bool IncludeTaxes { get; set; }

    [MaxLength(30), AllowNull]
    public string PaymentTerm { get; set; }

    public bool PayTerm60 { get; set; } 

    public DateOnly CompletionOrDeliveryDate { get; set; }

    [MaxLength(30), AllowNull]
    public string DeliveryAddress { get; set; }

    [MaxLength(30), AllowNull]
    public string Note { get; set; }

    // NEW: Form status property to track the approval workflow
    public FormStatus Status { get; set; } = FormStatus.Draft; // Default status is Draft
}

// Enum to define form statuses
public enum FormStatus
{
    Draft,          // Form is being filled
    Submitted,      // Submitted by user
    ApprovedByDirector, // Approved by the relevant director
    RejectedByDirector, // Rejected by the relevant director
    UnderLegalReview,   // Sent to legal department for review
    ApprovedByLegal,    // Approved by legal department
    RejectedByLegal,    // Rejected by legal department
    Completed       // Form is finalized and complete
}
