using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.PunchItems.Models {
	public class PunchItem {

		/// <summary>
		/// ID
		/// </summary>
		[JsonProperty("id")]	public  long Id { get ; set; }

		/// <summary>
		/// Array of Users
		/// </summary>
		[JsonProperty("ball_in_court")]	public  List<LoginInformation> BallInCourt { get ; set; }

		/// <summary>
		/// Punch Item Comments
		/// </summary>
		[JsonProperty("comments")]	public  List<Comment> Comments { get ; set; }

		/// <summary>
		/// Created at
		/// </summary>
		[JsonProperty("created_at")]	public  DateTimeOffset CreatedAt { get ; set; }

		/// <summary>
		/// Closed at
		/// </summary>
		[JsonProperty("closed_at")]	public  DateTimeOffset? ClosedAt { get ; set; }

		/// <summary>
		/// Deleted at
		/// </summary>
		[JsonProperty("deleted_at")]	public  DateTimeOffset? DeletedAt { get ; set; }

		/// <summary>
		/// Description
		/// </summary>
		[JsonProperty("description")]	public  string Description { get ; set; }

		/// <summary>
		/// Due Date
		/// </summary>
		[JsonProperty("due_date")]	public  string DueDate { get ; set; }

		/// <summary>
		/// Name
		/// </summary>
		[JsonProperty("name")]	public  string Name { get ; set; }

		/// <summary>
		/// Assessed risk level of on-time completion
		/// </summary>
		[JsonProperty("schedule_risk")]	public  string ScheduleRisk { get ; set; }

		/// <summary>
		/// Reason for assessed risk level of on-time completion
		/// </summary>
		[JsonProperty("schedule_risk_reason")]	public  string ScheduleRiskReason { get ; set; }

		/// <summary>
		/// Position
		/// </summary>
		[JsonProperty("position")]	public  int? Position { get ; set; }

		/// <summary>
		/// Punch item priority - 'low', 'medium', 'high'
		/// </summary>
		[JsonProperty("priority")]	public  string Priority { get ; set; }

		/// <summary>
		/// Privacy status
		/// </summary>
		[JsonProperty("private")]	public  bool Private { get ; set; }

		/// <summary>
		/// Status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Updated at
		/// </summary>
		[JsonProperty("updated_at")]	public  DateTimeOffset UpdatedAt { get ; set; }

		/// <summary>
		/// Date created
		/// </summary>
		[JsonProperty("date_initiated")]	public  string DateInitiated { get ; set; }

		/// <summary>
		/// Schedule impact status
		/// </summary>
		[JsonProperty("schedule_impact")]	public  string ScheduleImpact { get ; set; }

		/// <summary>
		/// Schedule impact value in days
		/// </summary>
		[JsonProperty("schedule_impact_days")]	public  int? ScheduleImpactDays { get ; set; }

		/// <summary>
		/// Used to create a reference point between a Punch Item within Procore and a corresponding Punch Item outside of Procore
		/// </summary>
		[JsonProperty("reference")]	public  string Reference { get ; set; }

		/// <summary>
		/// Cost impact status
		/// </summary>
		[JsonProperty("cost_impact")]	public  string CostImpact { get ; set; }

		/// <summary>
		/// Cost impact amount
		/// </summary>
		[JsonProperty("cost_impact_amount")]	public  int? CostImpactAmount { get ; set; }

		/// <summary>
		/// Punch Item has Punch Item Assignments or distribution members to email to
		/// </summary>
		[JsonProperty("can_email")]	public  bool CanEmail { get ; set; }

		/// <summary>
		/// Array of Drawing IDs
		/// </summary>
		[JsonProperty("drawing_ids")]	public  List<long> DrawingIds { get ; set; }

		/// <summary>
		/// Array of Current Drawing Revision IDs
		/// </summary>
		[JsonProperty("current_drawing_revision_ids")]	public  List<long> CurrentDrawingRevisionIds { get ; set; }

		/// <summary>
		/// Users on the Punch Item distribution list
		/// </summary>
		[JsonProperty("distribution_members")]	public  List<DistributionMember> DistributionMembers { get ; set; }

		[JsonProperty("location")]	public  Location Location { get ; set; }

		[JsonProperty("trade")]	public  Trade Trade { get ; set; }

		/// <summary>
		/// User that created the Punch Item
		/// </summary>
		[JsonProperty("created_by")]	public  PunchItemCreator CreatedBy { get ; set; }

		/// <summary>
		/// User that manages the Punch Item
		/// </summary>
		[JsonProperty("punch_item_manager")]	public  PunchItemManager PunchItemManager { get ; set; }

		/// <summary>
		/// User in charge of closing the Punch Item
		/// </summary>
		[JsonProperty("final_approver")]	public  PunchItemFinalApprover FinalApprover { get ; set; }

		[JsonProperty("punch_item_type")]	public  PunchItemType PunchItemType { get ; set; }

		[JsonProperty("cost_code")]	public  CostCode CostCode { get ; set; }

		/// <summary>
		/// Array of Punch Item Assignments
		/// </summary>
		[JsonProperty("assignments")]	public  List<Assignment> Assignments { get ; set; }

		/// <summary>
		/// Array of Punch Item Attachments
		/// </summary>
		[JsonProperty("attachments")]	public  List<Attachment> Attachments { get ; set; }

		/// <summary>
		/// Array of Images *DEPRECATED. Please use attachments instead
		/// </summary>
		[JsonProperty("images")]	public  List<Image> Images { get ; set; }

		/// <summary>
		/// Array of photo Attachments uploaded from the web application
		/// </summary>
		[JsonProperty("web_images")]	public  List<WebImage> WebImages { get ; set; }

		/// <summary>
		/// Workflow status of the Punch Item
		/// </summary>
		[JsonProperty("workflow_status")]	public  string WorkflowStatus { get ; set; }

		[JsonProperty("custom_fields")]	public  JObject CustomFields { get ; set; }
	}
}
