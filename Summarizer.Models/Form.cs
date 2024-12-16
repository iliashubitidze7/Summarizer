using System.ComponentModel.DataAnnotations;

public class Form
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateOnly StartingDate { get; set; }

    [Required, MaxLength(30)]
    public string Department { get; set; }

    [Required, MaxLength(30)]
    public string Person { get; set; }

    [Required, MaxLength(30)]
    public string RelevantDirector { get; set; }

    [Required, MaxLength(30)]
    public string IdentificationCode { get; set; }

    [Required, MaxLength(30)]
    public string SupplierMail { get; set; }

    [Required, MaxLength(30)]
    public string ContractType { get; set; }

    [Required, MaxLength(100)]
    public string Subject { get; set; }

    [Required, MaxLength(30)]
    public string Value { get; set; }

    [Required]
    public bool IncludeTaxes { get; set; }

    [Required]
    public bool VatPayer { get; set; }

    [Required, MaxLength(100)]
    public string PaymentTerm { get; set; }

    [Required]
    public bool PayTerm60 { get; set; }

    [Required]
    public DateOnly CompletionOrDeliveryDate { get; set; }

    [Required, MaxLength(50)]
    public string DeliveryAddress { get; set; }

    [Required]
    public string UsageType { get; set; }

    [Required]
    public DateOnly ContractEndDate { get; set; }

    [MaxLength(300)]
    public string Note { get; set; }

    // NEW: Form status property to track the approval workflow
    [Required]
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
