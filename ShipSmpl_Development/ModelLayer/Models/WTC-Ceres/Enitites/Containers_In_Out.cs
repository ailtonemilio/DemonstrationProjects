namespace ModelLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Containers In-Out")]
    public partial class Containers_In_Out
    {
        [Key]
        [Column("Unique ID")]
        public int Unique_ID { get; set; }

        [Column("Container Number")]
        [StringLength(11)]
        public string Container_Number { get; set; }

        [Column("Workstation In")]
        [StringLength(20)]
        public string Workstation_In { get; set; }

        [Column("Condition In")]
        [StringLength(1)]
        public string Condition_In { get; set; }

        [Column("Gate Date In")]
        public DateTime? Gate_Date_In { get; set; }

        [Column("Gate Time In")]
        public DateTime? Gate_Time_In { get; set; }

        [Column("Yard Code In")]
        [StringLength(10)]
        public string Yard_Code_In { get; set; }

        [Column("Yard Name In")]
        [StringLength(40)]
        public string Yard_Name_In { get; set; }

        [Column("Terminal Code In")]
        [StringLength(10)]
        public string Terminal_Code_In { get; set; }

        [Column("Terminal Name In")]
        [StringLength(40)]
        public string Terminal_Name_In { get; set; }

        [Column("Street Turn")]
        public bool? Street_Turn { get; set; }

        public int? ReleaseID { get; set; }

        [Column("Release Number")]
        [StringLength(40)]
        public string Release_Number { get; set; }

        [Column("Damage In")]
        [StringLength(1)]
        public string Damage_In { get; set; }

        [Column("SS Line Code In")]
        [StringLength(10)]
        public string SS_Line_Code_In { get; set; }

        [Column("SS Line Name In")]
        [StringLength(50)]
        public string SS_Line_Name_In { get; set; }

        [Column("Container Size")]
        [StringLength(1)]
        public string Container_Size { get; set; }

        [Column("Gross Weight")]
        [StringLength(4)]
        public string Gross_Weight { get; set; }

        [Column("TARE Weight")]
        [StringLength(4)]
        public string TARE_Weight { get; set; }

        [Column("Carrier Code In")]
        [StringLength(10)]
        public string Carrier_Code_In { get; set; }

        [Column("Carrier Name In")]
        [StringLength(50)]
        public string Carrier_Name_In { get; set; }

        [Column("Carrier Truck In")]
        [StringLength(10)]
        public string Carrier_Truck_In { get; set; }

        [Column("Carrier DriverID In")]
        [StringLength(15)]
        public string Carrier_DriverID_In { get; set; }

        [Column("Carrier DriverName In")]
        [StringLength(40)]
        public string Carrier_DriverName_In { get; set; }

        [Column("Comments In")]
        [StringLength(255)]
        public string Comments_In { get; set; }

        public bool? EmptyCanPicture { get; set; }

        [Column("Trouble In-Gate")]
        public bool? Trouble_In_Gate { get; set; }

        [Column("In-Gate To Excel")]
        public bool? In_Gate_To_Excel { get; set; }

        [Column("Assigned To Excel")]
        public bool? Assigned_To_Excel { get; set; }

        [Column("Assigned To Storage")]
        public bool? Assigned_To_Storage { get; set; }

        [Column("Assigned To Extra")]
        public bool? Assigned_To_Extra { get; set; }

        [Column("Excel Booking Number")]
        [StringLength(50)]
        public string Excel_Booking_Number { get; set; }

        [Column("Delivered Booking")]
        [StringLength(50)]
        public string Delivered_Booking { get; set; }

        [Column("Excel Filename In")]
        [StringLength(50)]
        public string Excel_Filename_In { get; set; }

        [Column("In Gate EDI")]
        public bool? In_Gate_EDI { get; set; }

        [Column("Workstation Out")]
        [StringLength(20)]
        public string Workstation_Out { get; set; }

        [Column("Condition Out")]
        [StringLength(1)]
        public string Condition_Out { get; set; }

        [Column("Gate Date Out")]
        public DateTime? Gate_Date_Out { get; set; }

        [Column("Gate Time Out")]
        public DateTime? Gate_Time_Out { get; set; }

        [Column("Yard Code Out")]
        [StringLength(10)]
        public string Yard_Code_Out { get; set; }

        [Column("Yard Name Out")]
        [StringLength(40)]
        public string Yard_Name_Out { get; set; }

        [Column("Terminal Code Out")]
        [StringLength(10)]
        public string Terminal_Code_Out { get; set; }

        [Column("Terminal Name Out")]
        [StringLength(40)]
        public string Terminal_Name_Out { get; set; }

        [Column("Booking Number")]
        [StringLength(40)]
        public string Booking_Number { get; set; }

        [Column("Damages Out")]
        [StringLength(1)]
        public string Damages_Out { get; set; }

        [Column("SS Line Code Out")]
        [StringLength(10)]
        public string SS_Line_Code_Out { get; set; }

        [Column("SS Line Name Out")]
        [StringLength(50)]
        public string SS_Line_Name_Out { get; set; }

        public bool? HasGrainDoor { get; set; }

        [Column("Seal Number")]
        [StringLength(10)]
        public string Seal_Number { get; set; }

        public bool? Loaded { get; set; }

        public bool? ScaleTicket { get; set; }

        [StringLength(11)]
        public string LRD { get; set; }

        [StringLength(11)]
        public string ERD { get; set; }

        [Column("Vessel Name")]
        [StringLength(80)]
        public string Vessel_Name { get; set; }

        [Column("Voyage Number")]
        [StringLength(20)]
        public string Voyage_Number { get; set; }

        [Column("Cargo Weight Out")]
        [StringLength(4)]
        public string Cargo_Weight_Out { get; set; }

        [Column("TARE Weight Out")]
        [StringLength(4)]
        public string TARE_Weight_Out { get; set; }

        [Column("Gross Weight Out")]
        [StringLength(4)]
        public string Gross_Weight_Out { get; set; }

        [Column("Pre Send EDI")]
        public bool? Pre_Send_EDI { get; set; }

        [Column("Carrier Code Out")]
        [StringLength(10)]
        public string Carrier_Code_Out { get; set; }

        [Column("Carrier Name Out")]
        [StringLength(50)]
        public string Carrier_Name_Out { get; set; }

        [Column("Carrier Truck Out")]
        [StringLength(10)]
        public string Carrier_Truck_Out { get; set; }

        [Column("Carrier DriverID Out")]
        [StringLength(15)]
        public string Carrier_DriverID_Out { get; set; }

        [Column("Carrier DriverName Out")]
        [StringLength(40)]
        public string Carrier_DriverName_Out { get; set; }

        [Column("Comments Out")]
        [StringLength(255)]
        public string Comments_Out { get; set; }

        [Column("Hold Out-Gate")]
        public bool? Hold_Out_Gate { get; set; }

        [Column("Excel Filename Out")]
        [StringLength(50)]
        public string Excel_Filename_Out { get; set; }

        [Column("Container Out-Gated")]
        public bool? Container_Out_Gated { get; set; }

        [Column("Out Gate EDI")]
        public bool? Out_Gate_EDI { get; set; }

        [Column("Container Rejected")]
        public bool? Container_Rejected { get; set; }

        [Column("In Gate EDI Date Time")]
        public DateTime? In_Gate_EDI_Date_Time { get; set; }

        [Column("Out Gate EDI Date Time")]
        public DateTime? Out_Gate_EDI_Date_Time { get; set; }

        [Column("Should Send InGate EDI")]
        public bool? Should_Send_InGate_EDI { get; set; }

        [Column("Export Destination")]
        [StringLength(100)]
        public string Export_Destination { get; set; }

        [Column("In-Gate Release Type")]
        [StringLength(1)]
        public string In_Gate_Release_Type { get; set; }

        [Column("Should Send OutGate EDI")]
        public bool? Should_Send_OutGate_EDI { get; set; }

        public double? GrossWeightIn { get; set; }

        public double? TareWeightIn { get; set; }

        public double? CargoWeight { get; set; }

        public double? GrossWeightOut { get; set; }

        public double? TareWeightOut { get; set; }

        [StringLength(10)]
        public string ContainerSize { get; set; }

        public int? MiniBookingId { get; set; }

        public int? ReleaseNId { get; set; }
    }
}
