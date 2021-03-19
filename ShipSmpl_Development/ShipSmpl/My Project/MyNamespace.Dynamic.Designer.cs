using System;
using System.ComponentModel;
using System.Diagnostics;

namespace ShipSmpl.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmActionDetails m_FrmActionDetails;

            public FrmActionDetails FrmActionDetails
            {
                [DebuggerHidden]
                get
                {
                    m_FrmActionDetails = Create__Instance__(m_FrmActionDetails);
                    return m_FrmActionDetails;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmActionDetails))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmActionDetails);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddComodity m_FrmAddComodity;

            public FrmAddComodity FrmAddComodity
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddComodity = Create__Instance__(m_FrmAddComodity);
                    return m_FrmAddComodity;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddComodity))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddComodity);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddContact m_FrmAddContact;

            public FrmAddContact FrmAddContact
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddContact = Create__Instance__(m_FrmAddContact);
                    return m_FrmAddContact;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddContact))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddContact);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmAddDepartment m_frmAddDepartment;

            public frmAddDepartment frmAddDepartment
            {
                [DebuggerHidden]
                get
                {
                    m_frmAddDepartment = Create__Instance__(m_frmAddDepartment);
                    return m_frmAddDepartment;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmAddDepartment))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmAddDepartment);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmAddDocumentType m_frmAddDocumentType;

            public frmAddDocumentType frmAddDocumentType
            {
                [DebuggerHidden]
                get
                {
                    m_frmAddDocumentType = Create__Instance__(m_frmAddDocumentType);
                    return m_frmAddDocumentType;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmAddDocumentType))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmAddDocumentType);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditBagInventoryLocation m_FrmAddEditBagInventoryLocation;

            public FrmAddEditBagInventoryLocation FrmAddEditBagInventoryLocation
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditBagInventoryLocation = Create__Instance__(m_FrmAddEditBagInventoryLocation);
                    return m_FrmAddEditBagInventoryLocation;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditBagInventoryLocation))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditBagInventoryLocation);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditBagLogo m_FrmAddEditBagLogo;

            public FrmAddEditBagLogo FrmAddEditBagLogo
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditBagLogo = Create__Instance__(m_FrmAddEditBagLogo);
                    return m_FrmAddEditBagLogo;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditBagLogo))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditBagLogo);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditCarrierReqDist m_FrmAddEditCarrierReqDist;

            public FrmAddEditCarrierReqDist FrmAddEditCarrierReqDist
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditCarrierReqDist = Create__Instance__(m_FrmAddEditCarrierReqDist);
                    return m_FrmAddEditCarrierReqDist;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditCarrierReqDist))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditCarrierReqDist);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditDestination m_FrmAddEditDestination;

            public FrmAddEditDestination FrmAddEditDestination
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditDestination = Create__Instance__(m_FrmAddEditDestination);
                    return m_FrmAddEditDestination;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditDestination))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditDestination);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditDistRequest m_FrmAddEditDistRequest;

            public FrmAddEditDistRequest FrmAddEditDistRequest
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditDistRequest = Create__Instance__(m_FrmAddEditDistRequest);
                    return m_FrmAddEditDistRequest;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditDistRequest))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditDistRequest);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditGrainInventory m_FrmAddEditGrainInventory;

            public FrmAddEditGrainInventory FrmAddEditGrainInventory
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditGrainInventory = Create__Instance__(m_FrmAddEditGrainInventory);
                    return m_FrmAddEditGrainInventory;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditGrainInventory))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditGrainInventory);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditInGate m_FrmAddEditInGate;

            public FrmAddEditInGate FrmAddEditInGate
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditInGate = Create__Instance__(m_FrmAddEditInGate);
                    return m_FrmAddEditInGate;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditInGate))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditInGate);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditInventory m_FrmAddEditInventory;

            public FrmAddEditInventory FrmAddEditInventory
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditInventory = Create__Instance__(m_FrmAddEditInventory);
                    return m_FrmAddEditInventory;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditInventory))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditInventory);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditOutGate m_FrmAddEditOutGate;

            public FrmAddEditOutGate FrmAddEditOutGate
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditOutGate = Create__Instance__(m_FrmAddEditOutGate);
                    return m_FrmAddEditOutGate;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditOutGate))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditOutGate);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditRegionCity m_FrmAddEditRegionCity;

            public FrmAddEditRegionCity FrmAddEditRegionCity
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditRegionCity = Create__Instance__(m_FrmAddEditRegionCity);
                    return m_FrmAddEditRegionCity;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditRegionCity))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditRegionCity);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditRelease m_FrmAddEditRelease;

            public FrmAddEditRelease FrmAddEditRelease
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditRelease = Create__Instance__(m_FrmAddEditRelease);
                    return m_FrmAddEditRelease;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditRelease))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditRelease);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditReleaseDetail m_FrmAddEditReleaseDetail;

            public FrmAddEditReleaseDetail FrmAddEditReleaseDetail
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditReleaseDetail = Create__Instance__(m_FrmAddEditReleaseDetail);
                    return m_FrmAddEditReleaseDetail;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditReleaseDetail))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditReleaseDetail);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditReleaseMb m_FrmAddEditReleaseMb;

            public FrmAddEditReleaseMb FrmAddEditReleaseMb
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditReleaseMb = Create__Instance__(m_FrmAddEditReleaseMb);
                    return m_FrmAddEditReleaseMb;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditReleaseMb))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditReleaseMb);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditReleasePickUpDropOff m_FrmAddEditReleasePickUpDropOff;

            public FrmAddEditReleasePickUpDropOff FrmAddEditReleasePickUpDropOff
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditReleasePickUpDropOff = Create__Instance__(m_FrmAddEditReleasePickUpDropOff);
                    return m_FrmAddEditReleasePickUpDropOff;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditReleasePickUpDropOff))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditReleasePickUpDropOff);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditRequest m_FrmAddEditRequest;

            public FrmAddEditRequest FrmAddEditRequest
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditRequest = Create__Instance__(m_FrmAddEditRequest);
                    return m_FrmAddEditRequest;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditRequest))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditRequest);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddEditServices m_FrmAddEditServices;

            public FrmAddEditServices FrmAddEditServices
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddEditServices = Create__Instance__(m_FrmAddEditServices);
                    return m_FrmAddEditServices;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddEditServices))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddEditServices);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmAddEditStoreFiles m_frmAddEditStoreFiles;

            public frmAddEditStoreFiles frmAddEditStoreFiles
            {
                [DebuggerHidden]
                get
                {
                    m_frmAddEditStoreFiles = Create__Instance__(m_frmAddEditStoreFiles);
                    return m_frmAddEditStoreFiles;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmAddEditStoreFiles))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmAddEditStoreFiles);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddMultipleUnits m_FrmAddMultipleUnits;

            public FrmAddMultipleUnits FrmAddMultipleUnits
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddMultipleUnits = Create__Instance__(m_FrmAddMultipleUnits);
                    return m_FrmAddMultipleUnits;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddMultipleUnits))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddMultipleUnits);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddNewEmployee m_FrmAddNewEmployee;

            public FrmAddNewEmployee FrmAddNewEmployee
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddNewEmployee = Create__Instance__(m_FrmAddNewEmployee);
                    return m_FrmAddNewEmployee;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddNewEmployee))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddNewEmployee);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddNewEntry m_FrmAddNewEntry;

            public FrmAddNewEntry FrmAddNewEntry
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddNewEntry = Create__Instance__(m_FrmAddNewEntry);
                    return m_FrmAddNewEntry;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddNewEntry))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddNewEntry);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddNewStartDate m_FrmAddNewStartDate;

            public FrmAddNewStartDate FrmAddNewStartDate
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddNewStartDate = Create__Instance__(m_FrmAddNewStartDate);
                    return m_FrmAddNewStartDate;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddNewStartDate))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddNewStartDate);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAddOrganization m_FrmAddOrganization;

            public FrmAddOrganization FrmAddOrganization
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAddOrganization = Create__Instance__(m_FrmAddOrganization);
                    return m_FrmAddOrganization;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAddOrganization))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAddOrganization);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAdjustBagsInventoryQty m_FrmAdjustBagsInventoryQty;

            public FrmAdjustBagsInventoryQty FrmAdjustBagsInventoryQty
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAdjustBagsInventoryQty = Create__Instance__(m_FrmAdjustBagsInventoryQty);
                    return m_FrmAdjustBagsInventoryQty;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAdjustBagsInventoryQty))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAdjustBagsInventoryQty);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAssignContainer m_FrmAssignContainer;

            public FrmAssignContainer FrmAssignContainer
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAssignContainer = Create__Instance__(m_FrmAssignContainer);
                    return m_FrmAssignContainer;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAssignContainer))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAssignContainer);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAssignStorageExtra m_FrmAssignStorageExtra;

            public FrmAssignStorageExtra FrmAssignStorageExtra
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAssignStorageExtra = Create__Instance__(m_FrmAssignStorageExtra);
                    return m_FrmAssignStorageExtra;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAssignStorageExtra))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAssignStorageExtra);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmAssignToUnits m_FrmAssignToUnits;

            public FrmAssignToUnits FrmAssignToUnits
            {
                [DebuggerHidden]
                get
                {
                    m_FrmAssignToUnits = Create__Instance__(m_FrmAssignToUnits);
                    return m_FrmAssignToUnits;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmAssignToUnits))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmAssignToUnits);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmAssignUnitToBooking m_frmAssignUnitToBooking;

            public frmAssignUnitToBooking frmAssignUnitToBooking
            {
                [DebuggerHidden]
                get
                {
                    m_frmAssignUnitToBooking = Create__Instance__(m_frmAssignUnitToBooking);
                    return m_frmAssignUnitToBooking;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmAssignUnitToBooking))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmAssignUnitToBooking);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmBlockContainer m_FrmBlockContainer;

            public FrmBlockContainer FrmBlockContainer
            {
                [DebuggerHidden]
                get
                {
                    m_FrmBlockContainer = Create__Instance__(m_FrmBlockContainer);
                    return m_FrmBlockContainer;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmBlockContainer))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmBlockContainer);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmBookingList m_FrmBookingList;

            public FrmBookingList FrmBookingList
            {
                [DebuggerHidden]
                get
                {
                    m_FrmBookingList = Create__Instance__(m_FrmBookingList);
                    return m_FrmBookingList;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmBookingList))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmBookingList);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmBookingReport m_FrmBookingReport;

            public FrmBookingReport FrmBookingReport
            {
                [DebuggerHidden]
                get
                {
                    m_FrmBookingReport = Create__Instance__(m_FrmBookingReport);
                    return m_FrmBookingReport;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmBookingReport))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmBookingReport);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmCardAssignment m_FrmCardAssignment;

            public FrmCardAssignment FrmCardAssignment
            {
                [DebuggerHidden]
                get
                {
                    m_FrmCardAssignment = Create__Instance__(m_FrmCardAssignment);
                    return m_FrmCardAssignment;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmCardAssignment))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmCardAssignment);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmCarrierAssignment m_FrmCarrierAssignment;

            public FrmCarrierAssignment FrmCarrierAssignment
            {
                [DebuggerHidden]
                get
                {
                    m_FrmCarrierAssignment = Create__Instance__(m_FrmCarrierAssignment);
                    return m_FrmCarrierAssignment;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmCarrierAssignment))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmCarrierAssignment);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmCFIALabel m_FrmCFIALabel;

            public FrmCFIALabel FrmCFIALabel
            {
                [DebuggerHidden]
                get
                {
                    m_FrmCFIALabel = Create__Instance__(m_FrmCFIALabel);
                    return m_FrmCFIALabel;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmCFIALabel))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmCFIALabel);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmChangeBooking m_FrmChangeBooking;

            public FrmChangeBooking FrmChangeBooking
            {
                [DebuggerHidden]
                get
                {
                    m_FrmChangeBooking = Create__Instance__(m_FrmChangeBooking);
                    return m_FrmChangeBooking;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmChangeBooking))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmChangeBooking);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmChangeEDI m_FrmChangeEDI;

            public FrmChangeEDI FrmChangeEDI
            {
                [DebuggerHidden]
                get
                {
                    m_FrmChangeEDI = Create__Instance__(m_FrmChangeEDI);
                    return m_FrmChangeEDI;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmChangeEDI))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmChangeEDI);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmClearance m_FrmClearance;

            public FrmClearance FrmClearance
            {
                [DebuggerHidden]
                get
                {
                    m_FrmClearance = Create__Instance__(m_FrmClearance);
                    return m_FrmClearance;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmClearance))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmClearance);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmCommodityGrainMain m_frmCommodityGrainMain;

            public frmCommodityGrainMain frmCommodityGrainMain
            {
                [DebuggerHidden]
                get
                {
                    m_frmCommodityGrainMain = Create__Instance__(m_frmCommodityGrainMain);
                    return m_frmCommodityGrainMain;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmCommodityGrainMain))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmCommodityGrainMain);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmConfirmPassword m_FrmConfirmPassword;

            public FrmConfirmPassword FrmConfirmPassword
            {
                [DebuggerHidden]
                get
                {
                    m_FrmConfirmPassword = Create__Instance__(m_FrmConfirmPassword);
                    return m_FrmConfirmPassword;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmConfirmPassword))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmConfirmPassword);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmContactsWarningMessage m_FrmContactsWarningMessage;

            public FrmContactsWarningMessage FrmContactsWarningMessage
            {
                [DebuggerHidden]
                get
                {
                    m_FrmContactsWarningMessage = Create__Instance__(m_FrmContactsWarningMessage);
                    return m_FrmContactsWarningMessage;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmContactsWarningMessage))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmContactsWarningMessage);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmCreatePreScript m_FrmCreatePreScript;

            public FrmCreatePreScript FrmCreatePreScript
            {
                [DebuggerHidden]
                get
                {
                    m_FrmCreatePreScript = Create__Instance__(m_FrmCreatePreScript);
                    return m_FrmCreatePreScript;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmCreatePreScript))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmCreatePreScript);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmCreateTransfer m_FrmCreateTransfer;

            public FrmCreateTransfer FrmCreateTransfer
            {
                [DebuggerHidden]
                get
                {
                    m_FrmCreateTransfer = Create__Instance__(m_FrmCreateTransfer);
                    return m_FrmCreateTransfer;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmCreateTransfer))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmCreateTransfer);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmCreateUsernameAndPassword m_FrmCreateUsernameAndPassword;

            public FrmCreateUsernameAndPassword FrmCreateUsernameAndPassword
            {
                [DebuggerHidden]
                get
                {
                    m_FrmCreateUsernameAndPassword = Create__Instance__(m_FrmCreateUsernameAndPassword);
                    return m_FrmCreateUsernameAndPassword;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmCreateUsernameAndPassword))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmCreateUsernameAndPassword);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmDeactivateBooking m_FrmDeactivateBooking;

            public FrmDeactivateBooking FrmDeactivateBooking
            {
                [DebuggerHidden]
                get
                {
                    m_FrmDeactivateBooking = Create__Instance__(m_FrmDeactivateBooking);
                    return m_FrmDeactivateBooking;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmDeactivateBooking))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmDeactivateBooking);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmdeleteWarning m_FrmdeleteWarning;

            public FrmdeleteWarning FrmdeleteWarning
            {
                [DebuggerHidden]
                get
                {
                    m_FrmdeleteWarning = Create__Instance__(m_FrmdeleteWarning);
                    return m_FrmdeleteWarning;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmdeleteWarning))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmdeleteWarning);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmDetailedEntry m_FrmDetailedEntry;

            public FrmDetailedEntry FrmDetailedEntry
            {
                [DebuggerHidden]
                get
                {
                    m_FrmDetailedEntry = Create__Instance__(m_FrmDetailedEntry);
                    return m_FrmDetailedEntry;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmDetailedEntry))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmDetailedEntry);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmDisplayContacts m_FrmDisplayContacts;

            public FrmDisplayContacts FrmDisplayContacts
            {
                [DebuggerHidden]
                get
                {
                    m_FrmDisplayContacts = Create__Instance__(m_FrmDisplayContacts);
                    return m_FrmDisplayContacts;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmDisplayContacts))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmDisplayContacts);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmDisplayTemplates m_FrmDisplayTemplates;

            public FrmDisplayTemplates FrmDisplayTemplates
            {
                [DebuggerHidden]
                get
                {
                    m_FrmDisplayTemplates = Create__Instance__(m_FrmDisplayTemplates);
                    return m_FrmDisplayTemplates;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmDisplayTemplates))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmDisplayTemplates);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmDistributeRecChangeMsg m_FrmDistributeRecChangeMsg;

            public FrmDistributeRecChangeMsg FrmDistributeRecChangeMsg
            {
                [DebuggerHidden]
                get
                {
                    m_FrmDistributeRecChangeMsg = Create__Instance__(m_FrmDistributeRecChangeMsg);
                    return m_FrmDistributeRecChangeMsg;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmDistributeRecChangeMsg))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmDistributeRecChangeMsg);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEDI m_FrmEDI;

            public FrmEDI FrmEDI
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEDI = Create__Instance__(m_FrmEDI);
                    return m_FrmEDI;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEDI))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEDI);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEDIManagement m_FrmEDIManagement;

            public FrmEDIManagement FrmEDIManagement
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEDIManagement = Create__Instance__(m_FrmEDIManagement);
                    return m_FrmEDIManagement;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEDIManagement))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEDIManagement);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmEDIPerformanceAudit m_frmEDIPerformanceAudit;

            public frmEDIPerformanceAudit frmEDIPerformanceAudit
            {
                [DebuggerHidden]
                get
                {
                    m_frmEDIPerformanceAudit = Create__Instance__(m_frmEDIPerformanceAudit);
                    return m_frmEDIPerformanceAudit;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmEDIPerformanceAudit))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmEDIPerformanceAudit);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmEDIPerformanceAuditMain m_frmEDIPerformanceAuditMain;

            public frmEDIPerformanceAuditMain frmEDIPerformanceAuditMain
            {
                [DebuggerHidden]
                get
                {
                    m_frmEDIPerformanceAuditMain = Create__Instance__(m_frmEDIPerformanceAuditMain);
                    return m_frmEDIPerformanceAuditMain;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmEDIPerformanceAuditMain))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmEDIPerformanceAuditMain);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmEDIPerformanceAuditReport m_frmEDIPerformanceAuditReport;

            public frmEDIPerformanceAuditReport frmEDIPerformanceAuditReport
            {
                [DebuggerHidden]
                get
                {
                    m_frmEDIPerformanceAuditReport = Create__Instance__(m_frmEDIPerformanceAuditReport);
                    return m_frmEDIPerformanceAuditReport;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmEDIPerformanceAuditReport))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmEDIPerformanceAuditReport);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEditAddBags m_FrmEditAddBags;

            public FrmEditAddBags FrmEditAddBags
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEditAddBags = Create__Instance__(m_FrmEditAddBags);
                    return m_FrmEditAddBags;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEditAddBags))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEditAddBags);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEditAddBooking m_FrmEditAddBooking;

            public FrmEditAddBooking FrmEditAddBooking
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEditAddBooking = Create__Instance__(m_FrmEditAddBooking);
                    return m_FrmEditAddBooking;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEditAddBooking))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEditAddBooking);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEditAddRailList m_FrmEditAddRailList;

            public FrmEditAddRailList FrmEditAddRailList
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEditAddRailList = Create__Instance__(m_FrmEditAddRailList);
                    return m_FrmEditAddRailList;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEditAddRailList))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEditAddRailList);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEditAddress m_FrmEditAddress;

            public FrmEditAddress FrmEditAddress
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEditAddress = Create__Instance__(m_FrmEditAddress);
                    return m_FrmEditAddress;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEditAddress))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEditAddress);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmEditCommodity m_frmEditCommodity;

            public frmEditCommodity frmEditCommodity
            {
                [DebuggerHidden]
                get
                {
                    m_frmEditCommodity = Create__Instance__(m_frmEditCommodity);
                    return m_frmEditCommodity;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmEditCommodity))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmEditCommodity);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEditDrayage m_FrmEditDrayage;

            public FrmEditDrayage FrmEditDrayage
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEditDrayage = Create__Instance__(m_FrmEditDrayage);
                    return m_FrmEditDrayage;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEditDrayage))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEditDrayage);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEditEntry m_FrmEditEntry;

            public FrmEditEntry FrmEditEntry
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEditEntry = Create__Instance__(m_FrmEditEntry);
                    return m_FrmEditEntry;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEditEntry))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEditEntry);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmEditGrade m_frmEditGrade;

            public frmEditGrade frmEditGrade
            {
                [DebuggerHidden]
                get
                {
                    m_frmEditGrade = Create__Instance__(m_frmEditGrade);
                    return m_frmEditGrade;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmEditGrade))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmEditGrade);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEditMBsCarrierOut m_FrmEditMBsCarrierOut;

            public FrmEditMBsCarrierOut FrmEditMBsCarrierOut
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEditMBsCarrierOut = Create__Instance__(m_FrmEditMBsCarrierOut);
                    return m_FrmEditMBsCarrierOut;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEditMBsCarrierOut))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEditMBsCarrierOut);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmEditTruckDrivers m_frmEditTruckDrivers;

            public frmEditTruckDrivers frmEditTruckDrivers
            {
                [DebuggerHidden]
                get
                {
                    m_frmEditTruckDrivers = Create__Instance__(m_frmEditTruckDrivers);
                    return m_frmEditTruckDrivers;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmEditTruckDrivers))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmEditTruckDrivers);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEmployeeDetails m_FrmEmployeeDetails;

            public FrmEmployeeDetails FrmEmployeeDetails
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEmployeeDetails = Create__Instance__(m_FrmEmployeeDetails);
                    return m_FrmEmployeeDetails;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEmployeeDetails))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEmployeeDetails);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEmployeeManagement m_FrmEmployeeManagement;

            public FrmEmployeeManagement FrmEmployeeManagement
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEmployeeManagement = Create__Instance__(m_FrmEmployeeManagement);
                    return m_FrmEmployeeManagement;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEmployeeManagement))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEmployeeManagement);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEmployeeManagementHP m_FrmEmployeeManagementHP;

            public FrmEmployeeManagementHP FrmEmployeeManagementHP
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEmployeeManagementHP = Create__Instance__(m_FrmEmployeeManagementHP);
                    return m_FrmEmployeeManagementHP;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEmployeeManagementHP))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEmployeeManagementHP);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmEmptyBagInvList m_FrmEmptyBagInvList;

            public FrmEmptyBagInvList FrmEmptyBagInvList
            {
                [DebuggerHidden]
                get
                {
                    m_FrmEmptyBagInvList = Create__Instance__(m_FrmEmptyBagInvList);
                    return m_FrmEmptyBagInvList;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmEmptyBagInvList))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmEmptyBagInvList);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmGrainInvList m_FrmGrainInvList;

            public FrmGrainInvList FrmGrainInvList
            {
                [DebuggerHidden]
                get
                {
                    m_FrmGrainInvList = Create__Instance__(m_FrmGrainInvList);
                    return m_FrmGrainInvList;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmGrainInvList))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmGrainInvList);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmGrainLocation m_FrmGrainLocation;

            public FrmGrainLocation FrmGrainLocation
            {
                [DebuggerHidden]
                get
                {
                    m_FrmGrainLocation = Create__Instance__(m_FrmGrainLocation);
                    return m_FrmGrainLocation;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmGrainLocation))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmGrainLocation);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmHolidays m_FrmHolidays;

            public FrmHolidays FrmHolidays
            {
                [DebuggerHidden]
                get
                {
                    m_FrmHolidays = Create__Instance__(m_FrmHolidays);
                    return m_FrmHolidays;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmHolidays))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmHolidays);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmHomePage m_FrmHomePage;

            public FrmHomePage FrmHomePage
            {
                [DebuggerHidden]
                get
                {
                    m_FrmHomePage = Create__Instance__(m_FrmHomePage);
                    return m_FrmHomePage;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmHomePage))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmHomePage);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmHoursWorkedYard m_frmHoursWorkedYard;

            public frmHoursWorkedYard frmHoursWorkedYard
            {
                [DebuggerHidden]
                get
                {
                    m_frmHoursWorkedYard = Create__Instance__(m_frmHoursWorkedYard);
                    return m_frmHoursWorkedYard;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmHoursWorkedYard))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmHoursWorkedYard);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmInConstruction m_FrmInConstruction;

            public FrmInConstruction FrmInConstruction
            {
                [DebuggerHidden]
                get
                {
                    m_FrmInConstruction = Create__Instance__(m_FrmInConstruction);
                    return m_FrmInConstruction;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmInConstruction))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmInConstruction);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmInOutGate m_FrmInOutGate;

            public FrmInOutGate FrmInOutGate
            {
                [DebuggerHidden]
                get
                {
                    m_FrmInOutGate = Create__Instance__(m_FrmInOutGate);
                    return m_FrmInOutGate;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmInOutGate))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmInOutGate);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmInvenotryDetail m_FrmInvenotryDetail;

            public FrmInvenotryDetail FrmInvenotryDetail
            {
                [DebuggerHidden]
                get
                {
                    m_FrmInvenotryDetail = Create__Instance__(m_FrmInvenotryDetail);
                    return m_FrmInvenotryDetail;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmInvenotryDetail))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmInvenotryDetail);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmListBlockedContainers m_FrmListBlockedContainers;

            public FrmListBlockedContainers FrmListBlockedContainers
            {
                [DebuggerHidden]
                get
                {
                    m_FrmListBlockedContainers = Create__Instance__(m_FrmListBlockedContainers);
                    return m_FrmListBlockedContainers;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmListBlockedContainers))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmListBlockedContainers);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmListContainers m_FrmListContainers;

            public FrmListContainers FrmListContainers
            {
                [DebuggerHidden]
                get
                {
                    m_FrmListContainers = Create__Instance__(m_FrmListContainers);
                    return m_FrmListContainers;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmListContainers))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmListContainers);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmListDistributions m_FrmListDistributions;

            public FrmListDistributions FrmListDistributions
            {
                [DebuggerHidden]
                get
                {
                    m_FrmListDistributions = Create__Instance__(m_FrmListDistributions);
                    return m_FrmListDistributions;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmListDistributions))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmListDistributions);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmListReleases m_FrmListReleases;

            public FrmListReleases FrmListReleases
            {
                [DebuggerHidden]
                get
                {
                    m_FrmListReleases = Create__Instance__(m_FrmListReleases);
                    return m_FrmListReleases;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmListReleases))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmListReleases);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmListRequests m_FrmListRequests;

            public FrmListRequests FrmListRequests
            {
                [DebuggerHidden]
                get
                {
                    m_FrmListRequests = Create__Instance__(m_FrmListRequests);
                    return m_FrmListRequests;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmListRequests))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmListRequests);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmListTransfers m_FrmListTransfers;

            public FrmListTransfers FrmListTransfers
            {
                [DebuggerHidden]
                get
                {
                    m_FrmListTransfers = Create__Instance__(m_FrmListTransfers);
                    return m_FrmListTransfers;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmListTransfers))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmListTransfers);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
          //  public FrmLoading m_FrmLoading;

            //public FrmLoading FrmLoading
            //{
            //    [DebuggerHidden]
            //    get
            //    {
            //        m_FrmLoading = Create__Instance__(m_FrmLoading);
            //        return m_FrmLoading;
            //    }

            //    [DebuggerHidden]
            //    set
            //    {
            //        if (ReferenceEquals(value, m_FrmLoading))
            //            return;
            //        if (value is object)
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        Dispose__Instance__(ref m_FrmLoading);
            //    }
            //}

            //[EditorBrowsable(EditorBrowsableState.Never)]
            //public frmLoadingPDF m_frmLoadingPDF;

            //public frmLoadingPDF frmLoadingPDF
            //{
            //    [DebuggerHidden]
            //    get
            //    {
            //        m_frmLoadingPDF = Create__Instance__(m_frmLoadingPDF);
            //        return m_frmLoadingPDF;
            //    }

            //    [DebuggerHidden]
            //    set
            //    {
            //        if (ReferenceEquals(value, m_frmLoadingPDF))
            //            return;
            //        if (value is object)
            //            throw new ArgumentException("Property can only be set to Nothing");
            //        Dispose__Instance__(ref m_frmLoadingPDF);
            //    }
            //}

         //   [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmLoginWindow m_FrmLoginWindow;

            public FrmLoginWindow FrmLoginWindow
            {
                [DebuggerHidden]
                get
                {
                    m_FrmLoginWindow = Create__Instance__(m_FrmLoginWindow);
                    return m_FrmLoginWindow;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmLoginWindow))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmLoginWindow);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmLogs m_FrmLogs;

            public FrmLogs FrmLogs
            {
                [DebuggerHidden]
                get
                {
                    m_FrmLogs = Create__Instance__(m_FrmLogs);
                    return m_FrmLogs;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmLogs))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmLogs);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmManageReleaseBalance m_FrmManageReleaseBalance;

            public FrmManageReleaseBalance FrmManageReleaseBalance
            {
                [DebuggerHidden]
                get
                {
                    m_FrmManageReleaseBalance = Create__Instance__(m_FrmManageReleaseBalance);
                    return m_FrmManageReleaseBalance;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmManageReleaseBalance))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmManageReleaseBalance);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmManageServices m_FrmManageServices;

            public FrmManageServices FrmManageServices
            {
                [DebuggerHidden]
                get
                {
                    m_FrmManageServices = Create__Instance__(m_FrmManageServices);
                    return m_FrmManageServices;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmManageServices))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmManageServices);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmMessage m_FrmMessage;

            public FrmMessage FrmMessage
            {
                [DebuggerHidden]
                get
                {
                    m_FrmMessage = Create__Instance__(m_FrmMessage);
                    return m_FrmMessage;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmMessage))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmMessage);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmMiniBookingWarning m_FrmMiniBookingWarning;

            public FrmMiniBookingWarning FrmMiniBookingWarning
            {
                [DebuggerHidden]
                get
                {
                    m_FrmMiniBookingWarning = Create__Instance__(m_FrmMiniBookingWarning);
                    return m_FrmMiniBookingWarning;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmMiniBookingWarning))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmMiniBookingWarning);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmMiniUnitToAssign m_frmMiniUnitToAssign;

            public frmMiniUnitToAssign frmMiniUnitToAssign
            {
                [DebuggerHidden]
                get
                {
                    m_frmMiniUnitToAssign = Create__Instance__(m_frmMiniUnitToAssign);
                    return m_frmMiniUnitToAssign;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmMiniUnitToAssign))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmMiniUnitToAssign);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmMissingUnits m_FrmMissingUnits;

            public FrmMissingUnits FrmMissingUnits
            {
                [DebuggerHidden]
                get
                {
                    m_FrmMissingUnits = Create__Instance__(m_FrmMissingUnits);
                    return m_FrmMissingUnits;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmMissingUnits))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmMissingUnits);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmModifyMUBilledValues m_FrmModifyMUBilledValues;

            public FrmModifyMUBilledValues FrmModifyMUBilledValues
            {
                [DebuggerHidden]
                get
                {
                    m_FrmModifyMUBilledValues = Create__Instance__(m_FrmModifyMUBilledValues);
                    return m_FrmModifyMUBilledValues;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmModifyMUBilledValues))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmModifyMUBilledValues);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmModifyTotalNumbCont m_FrmModifyTotalNumbCont;

            public FrmModifyTotalNumbCont FrmModifyTotalNumbCont
            {
                [DebuggerHidden]
                get
                {
                    m_FrmModifyTotalNumbCont = Create__Instance__(m_FrmModifyTotalNumbCont);
                    return m_FrmModifyTotalNumbCont;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmModifyTotalNumbCont))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmModifyTotalNumbCont);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmOutGateReport m_FrmOutGateReport;

            public FrmOutGateReport FrmOutGateReport
            {
                [DebuggerHidden]
                get
                {
                    m_FrmOutGateReport = Create__Instance__(m_FrmOutGateReport);
                    return m_FrmOutGateReport;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmOutGateReport))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmOutGateReport);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmParentScreen m_FrmParentScreen;

            public FrmParentScreen FrmParentScreen
            {
                [DebuggerHidden]
                get
                {
                    m_FrmParentScreen = Create__Instance__(m_FrmParentScreen);
                    return m_FrmParentScreen;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmParentScreen))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmParentScreen);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmPrintCard m_FrmPrintCard;

            public FrmPrintCard FrmPrintCard
            {
                [DebuggerHidden]
                get
                {
                    m_FrmPrintCard = Create__Instance__(m_FrmPrintCard);
                    return m_FrmPrintCard;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmPrintCard))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmPrintCard);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmPushBooking m_FrmPushBooking;

            public FrmPushBooking FrmPushBooking
            {
                [DebuggerHidden]
                get
                {
                    m_FrmPushBooking = Create__Instance__(m_FrmPushBooking);
                    return m_FrmPushBooking;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmPushBooking))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmPushBooking);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmRailList m_FrmRailList;

            public FrmRailList FrmRailList
            {
                [DebuggerHidden]
                get
                {
                    m_FrmRailList = Create__Instance__(m_FrmRailList);
                    return m_FrmRailList;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmRailList))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmRailList);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmReceiptsReport m_FrmReceiptsReport;

            public FrmReceiptsReport FrmReceiptsReport
            {
                [DebuggerHidden]
                get
                {
                    m_FrmReceiptsReport = Create__Instance__(m_FrmReceiptsReport);
                    return m_FrmReceiptsReport;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmReceiptsReport))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmReceiptsReport);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmRelDistSchDeclined m_FrmRelDistSchDeclined;

            public FrmRelDistSchDeclined FrmRelDistSchDeclined
            {
                [DebuggerHidden]
                get
                {
                    m_FrmRelDistSchDeclined = Create__Instance__(m_FrmRelDistSchDeclined);
                    return m_FrmRelDistSchDeclined;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmRelDistSchDeclined))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmRelDistSchDeclined);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmReminderDetails m_FrmReminderDetails;

            public FrmReminderDetails FrmReminderDetails
            {
                [DebuggerHidden]
                get
                {
                    m_FrmReminderDetails = Create__Instance__(m_FrmReminderDetails);
                    return m_FrmReminderDetails;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmReminderDetails))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmReminderDetails);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmReportEmployeeIsworking m_frmReportEmployeeIsworking;

            public frmReportEmployeeIsworking frmReportEmployeeIsworking
            {
                [DebuggerHidden]
                get
                {
                    m_frmReportEmployeeIsworking = Create__Instance__(m_frmReportEmployeeIsworking);
                    return m_frmReportEmployeeIsworking;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmReportEmployeeIsworking))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmReportEmployeeIsworking);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmReportViwer m_FrmReportViwer;

            public FrmReportViwer FrmReportViwer
            {
                [DebuggerHidden]
                get
                {
                    m_FrmReportViwer = Create__Instance__(m_FrmReportViwer);
                    return m_FrmReportViwer;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmReportViwer))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmReportViwer);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmReturnSplitMiniUnit m_frmReturnSplitMiniUnit;

            public frmReturnSplitMiniUnit frmReturnSplitMiniUnit
            {
                [DebuggerHidden]
                get
                {
                    m_frmReturnSplitMiniUnit = Create__Instance__(m_frmReturnSplitMiniUnit);
                    return m_frmReturnSplitMiniUnit;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmReturnSplitMiniUnit))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmReturnSplitMiniUnit);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmRulesAndActions m_FrmRulesAndActions;

            public FrmRulesAndActions FrmRulesAndActions
            {
                [DebuggerHidden]
                get
                {
                    m_FrmRulesAndActions = Create__Instance__(m_FrmRulesAndActions);
                    return m_FrmRulesAndActions;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmRulesAndActions))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmRulesAndActions);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmSafetyRiskMain m_FrmSafetyRiskMain;

            public FrmSafetyRiskMain FrmSafetyRiskMain
            {
                [DebuggerHidden]
                get
                {
                    m_FrmSafetyRiskMain = Create__Instance__(m_FrmSafetyRiskMain);
                    return m_FrmSafetyRiskMain;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmSafetyRiskMain))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmSafetyRiskMain);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmSafetyRiskManagement m_FrmSafetyRiskManagement;

            public FrmSafetyRiskManagement FrmSafetyRiskManagement
            {
                [DebuggerHidden]
                get
                {
                    m_FrmSafetyRiskManagement = Create__Instance__(m_FrmSafetyRiskManagement);
                    return m_FrmSafetyRiskManagement;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmSafetyRiskManagement))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmSafetyRiskManagement);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmServices m_FrmServices;

            public FrmServices FrmServices
            {
                [DebuggerHidden]
                get
                {
                    m_FrmServices = Create__Instance__(m_FrmServices);
                    return m_FrmServices;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmServices))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmServices);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmShiftScheduling m_FrmShiftScheduling;

            public FrmShiftScheduling FrmShiftScheduling
            {
                [DebuggerHidden]
                get
                {
                    m_FrmShiftScheduling = Create__Instance__(m_FrmShiftScheduling);
                    return m_FrmShiftScheduling;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmShiftScheduling))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmShiftScheduling);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmSplitbooking m_FrmSplitbooking;

            public FrmSplitbooking FrmSplitbooking
            {
                [DebuggerHidden]
                get
                {
                    m_FrmSplitbooking = Create__Instance__(m_FrmSplitbooking);
                    return m_FrmSplitbooking;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmSplitbooking))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmSplitbooking);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmSplitContainersg m_FrmSplitContainersg;

            public FrmSplitContainersg FrmSplitContainersg
            {
                [DebuggerHidden]
                get
                {
                    m_FrmSplitContainersg = Create__Instance__(m_FrmSplitContainersg);
                    return m_FrmSplitContainersg;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmSplitContainersg))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmSplitContainersg);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmSplitMiniUnit m_frmSplitMiniUnit;

            public frmSplitMiniUnit frmSplitMiniUnit
            {
                [DebuggerHidden]
                get
                {
                    m_frmSplitMiniUnit = Create__Instance__(m_frmSplitMiniUnit);
                    return m_frmSplitMiniUnit;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmSplitMiniUnit))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmSplitMiniUnit);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmStoreFiles m_frmStoreFiles;

            public frmStoreFiles frmStoreFiles
            {
                [DebuggerHidden]
                get
                {
                    m_frmStoreFiles = Create__Instance__(m_frmStoreFiles);
                    return m_frmStoreFiles;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmStoreFiles))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmStoreFiles);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmSuspention m_FrmSuspention;

            public FrmSuspention FrmSuspention
            {
                [DebuggerHidden]
                get
                {
                    m_FrmSuspention = Create__Instance__(m_FrmSuspention);
                    return m_FrmSuspention;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmSuspention))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmSuspention);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTestCountry m_FrmTestCountry;

            public FrmTestCountry FrmTestCountry
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTestCountry = Create__Instance__(m_FrmTestCountry);
                    return m_FrmTestCountry;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTestCountry))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTestCountry);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTimeReport m_FrmTimeReport;

            public FrmTimeReport FrmTimeReport
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTimeReport = Create__Instance__(m_FrmTimeReport);
                    return m_FrmTimeReport;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTimeReport))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTimeReport);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTimeSheet m_FrmTimeSheet;

            public FrmTimeSheet FrmTimeSheet
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTimeSheet = Create__Instance__(m_FrmTimeSheet);
                    return m_FrmTimeSheet;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTimeSheet))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTimeSheet);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTimeTracker m_FrmTimeTracker;

            public FrmTimeTracker FrmTimeTracker
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTimeTracker = Create__Instance__(m_FrmTimeTracker);
                    return m_FrmTimeTracker;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTimeTracker))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTimeTracker);
                }
            }

            
            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTruckingRecon m_FrmTruckingRecon;

            public FrmTruckingRecon FrmTruckingRecon
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTruckingRecon = Create__Instance__(m_FrmTruckingRecon);
                    return m_FrmTruckingRecon;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTruckingRecon))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTruckingRecon);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmTypeInfoForDeletion m_FrmTypeInfoForDeletion;

            public FrmTypeInfoForDeletion FrmTypeInfoForDeletion
            {
                [DebuggerHidden]
                get
                {
                    m_FrmTypeInfoForDeletion = Create__Instance__(m_FrmTypeInfoForDeletion);
                    return m_FrmTypeInfoForDeletion;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmTypeInfoForDeletion))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmTypeInfoForDeletion);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmUpdateReqStatus m_FrmUpdateReqStatus;

            public FrmUpdateReqStatus FrmUpdateReqStatus
            {
                [DebuggerHidden]
                get
                {
                    m_FrmUpdateReqStatus = Create__Instance__(m_FrmUpdateReqStatus);
                    return m_FrmUpdateReqStatus;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmUpdateReqStatus))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmUpdateReqStatus);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public FrmUseInvQty m_FrmUseInvQty;

            public FrmUseInvQty FrmUseInvQty
            {
                [DebuggerHidden]
                get
                {
                    m_FrmUseInvQty = Create__Instance__(m_FrmUseInvQty);
                    return m_FrmUseInvQty;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_FrmUseInvQty))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_FrmUseInvQty);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmVesselAddEdit m_frmVesselAddEdit;

            public frmVesselAddEdit frmVesselAddEdit
            {
                [DebuggerHidden]
                get
                {
                    m_frmVesselAddEdit = Create__Instance__(m_frmVesselAddEdit);
                    return m_frmVesselAddEdit;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmVesselAddEdit))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmVesselAddEdit);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmVesselCSVUpdate m_frmVesselCSVUpdate;

            public frmVesselCSVUpdate frmVesselCSVUpdate
            {
                [DebuggerHidden]
                get
                {
                    m_frmVesselCSVUpdate = Create__Instance__(m_frmVesselCSVUpdate);
                    return m_frmVesselCSVUpdate;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmVesselCSVUpdate))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmVesselCSVUpdate);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmVesselList m_frmVesselList;

            public frmVesselList frmVesselList
            {
                [DebuggerHidden]
                get
                {
                    m_frmVesselList = Create__Instance__(m_frmVesselList);
                    return m_frmVesselList;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmVesselList))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmVesselList);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmVesselVoyageAddEdit m_frmVesselVoyageAddEdit;

            public frmVesselVoyageAddEdit frmVesselVoyageAddEdit
            {
                [DebuggerHidden]
                get
                {
                    m_frmVesselVoyageAddEdit = Create__Instance__(m_frmVesselVoyageAddEdit);
                    return m_frmVesselVoyageAddEdit;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmVesselVoyageAddEdit))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmVesselVoyageAddEdit);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmVesselVoyageCSVUpdateType m_frmVesselVoyageCSVUpdateType;

            public frmVesselVoyageCSVUpdateType frmVesselVoyageCSVUpdateType
            {
                [DebuggerHidden]
                get
                {
                    m_frmVesselVoyageCSVUpdateType = Create__Instance__(m_frmVesselVoyageCSVUpdateType);
                    return m_frmVesselVoyageCSVUpdateType;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmVesselVoyageCSVUpdateType))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmVesselVoyageCSVUpdateType);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmVesselVoyageList m_frmVesselVoyageList;

            public frmVesselVoyageList frmVesselVoyageList
            {
                [DebuggerHidden]
                get
                {
                    m_frmVesselVoyageList = Create__Instance__(m_frmVesselVoyageList);
                    return m_frmVesselVoyageList;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmVesselVoyageList))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmVesselVoyageList);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public frmWebBrowserPDF m_frmWebBrowserPDF;

            public frmWebBrowserPDF frmWebBrowserPDF
            {
                [DebuggerHidden]
                get
                {
                    m_frmWebBrowserPDF = Create__Instance__(m_frmWebBrowserPDF);
                    return m_frmWebBrowserPDF;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_frmWebBrowserPDF))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_frmWebBrowserPDF);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MessageBoxCeresOK m_MessageBoxCeresOK;

            public MessageBoxCeresOK MessageBoxCeresOK
            {
                [DebuggerHidden]
                get
                {
                    m_MessageBoxCeresOK = Create__Instance__(m_MessageBoxCeresOK);
                    return m_MessageBoxCeresOK;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MessageBoxCeresOK))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MessageBoxCeresOK);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MessageBoxCeresYesNo m_MessageBoxCeresYesNo;

            public MessageBoxCeresYesNo MessageBoxCeresYesNo
            {
                [DebuggerHidden]
                get
                {
                    m_MessageBoxCeresYesNo = Create__Instance__(m_MessageBoxCeresYesNo);
                    return m_MessageBoxCeresYesNo;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MessageBoxCeresYesNo))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MessageBoxCeresYesNo);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MessageBoxConfirmDelete m_MessageBoxConfirmDelete;

            public MessageBoxConfirmDelete MessageBoxConfirmDelete
            {
                [DebuggerHidden]
                get
                {
                    m_MessageBoxConfirmDelete = Create__Instance__(m_MessageBoxConfirmDelete);
                    return m_MessageBoxConfirmDelete;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MessageBoxConfirmDelete))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MessageBoxConfirmDelete);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public MessageBoxCustomerMatchingWarning m_MessageBoxCustomerMatchingWarning;

            public MessageBoxCustomerMatchingWarning MessageBoxCustomerMatchingWarning
            {
                [DebuggerHidden]
                get
                {
                    m_MessageBoxCustomerMatchingWarning = Create__Instance__(m_MessageBoxCustomerMatchingWarning);
                    return m_MessageBoxCustomerMatchingWarning;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_MessageBoxCustomerMatchingWarning))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_MessageBoxCustomerMatchingWarning);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public pictureViwer m_pictureViwer;

            public pictureViwer pictureViwer
            {
                [DebuggerHidden]
                get
                {
                    m_pictureViwer = Create__Instance__(m_pictureViwer);
                    return m_pictureViwer;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_pictureViwer))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_pictureViwer);
                }
            }
        }
    }
}