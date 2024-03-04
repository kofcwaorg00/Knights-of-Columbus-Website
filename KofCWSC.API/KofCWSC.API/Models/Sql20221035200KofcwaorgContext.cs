using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KofCWSC.API.Models;

public partial class Sql20221035200KofcwaorgContext : DbContext
{
    public Sql20221035200KofcwaorgContext()
    {
    }

    public Sql20221035200KofcwaorgContext(DbContextOptions<Sql20221035200KofcwaorgContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }

    public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; }

    public virtual DbSet<AspnetPath> AspnetPaths { get; set; }

    public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }

    public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }

    public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }

    public virtual DbSet<AspnetRole> AspnetRoles { get; set; }

    public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }

    public virtual DbSet<AspnetUser> AspnetUsers { get; set; }

    public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }

    public virtual DbSet<Dtproperty> Dtproperties { get; set; }

    public virtual DbSet<ImportEmail> ImportEmails { get; set; }

    public virtual DbSet<QryMemberOffice> QryMemberOffices { get; set; }

    public virtual DbSet<QryRptbulletin> QryRptbulletins { get; set; }

    public virtual DbSet<QryRptlabelsObsolete20100528> QryRptlabelsObsolete20100528s { get; set; }

    public virtual DbSet<QryRptliabIn> QryRptliabIns { get; set; }

    public virtual DbSet<QryRptmemberDataAll> QryRptmemberDataAlls { get; set; }

    public virtual DbSet<QryRptmemberDataAllOld> QryRptmemberDataAllOlds { get; set; }

    public virtual DbSet<QryRptmemberDataAllTim> QryRptmemberDataAllTims { get; set; }

    public virtual DbSet<QryRptrollCallSubDelegate> QryRptrollCallSubDelegates { get; set; }

    public virtual DbSet<QryRptrollCallSubOther> QryRptrollCallSubOthers { get; set; }

    public virtual DbSet<Roster> Rosters { get; set; }

    public virtual DbSet<TblArInvoiceDetail> TblArInvoiceDetails { get; set; }

    public virtual DbSet<TblArInvoiceHeader> TblArInvoiceHeaders { get; set; }

    public virtual DbSet<TblArInvoiceItem> TblArInvoiceItems { get; set; }

    public virtual DbSet<TblArPaymentDetail> TblArPaymentDetails { get; set; }

    public virtual DbSet<TblAspnetApplicationsTemp> TblAspnetApplicationsTemps { get; set; }

    public virtual DbSet<TblAspnetMmembershipTemp> TblAspnetMmembershipTemps { get; set; }

    public virtual DbSet<TblAspnetRolesTemp> TblAspnetRolesTemps { get; set; }

    public virtual DbSet<TblCorrDddistrict> TblCorrDddistricts { get; set; }

    public virtual DbSet<TblCorrGroupOffice> TblCorrGroupOffices { get; set; }

    public virtual DbSet<TblCorrGroupOfficeHistory> TblCorrGroupOfficeHistories { get; set; }

    public virtual DbSet<TblCorrMemberGroup> TblCorrMemberGroups { get; set; }

    public virtual DbSet<TblCorrMemberGroup2010Obsolete> TblCorrMemberGroup2010Obsoletes { get; set; }

    public virtual DbSet<TblCorrMemberGroupHistory> TblCorrMemberGroupHistories { get; set; }

    public virtual DbSet<TblCorrMemberOffice> TblCorrMemberOffices { get; set; }

    public virtual DbSet<TblCorrMemberOffice2010Obsolete> TblCorrMemberOffice2010Obsoletes { get; set; }

    public virtual DbSet<TblCorrMemberOfficeHistory> TblCorrMemberOfficeHistories { get; set; }

    public virtual DbSet<TblCvnControl> TblCvnControls { get; set; }

    public virtual DbSet<TblMasMember> TblMasMembers { get; set; }

    public virtual DbSet<TblMasMembersArchive> TblMasMembersArchives { get; set; }

    public virtual DbSet<TblMasMembersTest> TblMasMembersTests { get; set; }

    public virtual DbSet<TblMasMileage> TblMasMileages { get; set; }

    public virtual DbSet<TblMemTrxDirChange> TblMemTrxDirChanges { get; set; }

    public virtual DbSet<TblMsrReportPeriod> TblMsrReportPeriods { get; set; }

    public virtual DbSet<TblRpt4wavItem> TblRpt4wavItems { get; set; }

    public virtual DbSet<TblRptDirChangeItem> TblRptDirChangeItems { get; set; }

    public virtual DbSet<TblRptMasItem> TblRptMasItems { get; set; }

    public virtual DbSet<TblRptTrxReportItem> TblRptTrxReportItems { get; set; }

    public virtual DbSet<TblRptTrxReportItemsSave> TblRptTrxReportItemsSaves { get; set; }

    public virtual DbSet<TblRptValMsrtype> TblRptValMsrtypes { get; set; }

    public virtual DbSet<TblRptValReportType> TblRptValReportTypes { get; set; }

    public virtual DbSet<TblSysActiveUser> TblSysActiveUsers { get; set; }

    public virtual DbSet<TblSysBulletinLog> TblSysBulletinLogs { get; set; }

    public virtual DbSet<TblSysCalendar> TblSysCalendars { get; set; }

    public virtual DbSet<TblSysCalendar20> TblSysCalendar20s { get; set; }

    public virtual DbSet<TblSysControl> TblSysControls { get; set; }

    public virtual DbSet<TblSysLoginLog> TblSysLoginLogs { get; set; }

    public virtual DbSet<TblSysMailList> TblSysMailLists { get; set; }

    public virtual DbSet<TblSysRawCc> TblSysRawCcs { get; set; }

    public virtual DbSet<TblSysRawMember> TblSysRawMembers { get; set; }

    public virtual DbSet<TblSysRawMemberFullState> TblSysRawMemberFullStates { get; set; }

    public virtual DbSet<TblSysRawMembers201007> TblSysRawMembers201007s { get; set; }

    public virtual DbSet<TblSysRawMembersFromMm> TblSysRawMembersFromMms { get; set; }

    public virtual DbSet<TblSysRolePerm> TblSysRolePerms { get; set; }

    public virtual DbSet<TblSysSessionState> TblSysSessionStates { get; set; }

    public virtual DbSet<TblSysUserRole> TblSysUserRoles { get; set; }

    public virtual DbSet<TblSysValObject> TblSysValObjects { get; set; }

    public virtual DbSet<TblSysValObjectType> TblSysValObjectTypes { get; set; }

    public virtual DbSet<TblSysValRole> TblSysValRoles { get; set; }

    public virtual DbSet<TblTmpEmailBounce> TblTmpEmailBounces { get; set; }

    public virtual DbSet<TblTrxMpd> TblTrxMpds { get; set; }

    public virtual DbSet<TblTrxMpdarchive> TblTrxMpdarchives { get; set; }

    public virtual DbSet<TblUiControl> TblUiControls { get; set; }

    public virtual DbSet<TblValAssy> TblValAssys { get; set; }

    public virtual DbSet<TblValCircle> TblValCircles { get; set; }

    public virtual DbSet<TblValCouncil> TblValCouncils { get; set; }

    public virtual DbSet<TblValDiocese> TblValDioceses { get; set; }

    public virtual DbSet<TblValDistrict> TblValDistricts { get; set; }

    public virtual DbSet<TblValGroup> TblValGroups { get; set; }

    public virtual DbSet<TblValOffice> TblValOffices { get; set; }

    public virtual DbSet<TblValRptPeriod> TblValRptPeriods { get; set; }

    public virtual DbSet<TblValState> TblValStates { get; set; }

    public virtual DbSet<TblWebSelfPublish> TblWebSelfPublishes { get; set; }

    public virtual DbSet<TblWscCorMemberOffice> TblWscCorMemberOffices { get; set; }

    public virtual DbSet<TblWscMasMember> TblWscMasMembers { get; set; }

    public virtual DbSet<TblWscValAssembly> TblWscValAssemblies { get; set; }

    public virtual DbSet<TblWscValCouncil> TblWscValCouncils { get; set; }

    public virtual DbSet<TblWscValDiocese> TblWscValDioceses { get; set; }

    public virtual DbSet<TblWscValDistrict> TblWscValDistricts { get; set; }

    public virtual DbSet<TblWscValGroup> TblWscValGroups { get; set; }

    public virtual DbSet<TblWscValOffice> TblWscValOffices { get; set; }

    public virtual DbSet<Tim> Tims { get; set; }

    public virtual DbSet<TmpMileage> TmpMileages { get; set; }

    public virtual DbSet<VewSysCc> VewSysCcs { get; set; }

    public virtual DbSet<VewSysChaplain> VewSysChaplains { get; set; }

    public virtual DbSet<VewSysCorrMemberGroup> VewSysCorrMemberGroups { get; set; }

    public virtual DbSet<VewSysCorrMemberOffice> VewSysCorrMemberOffices { get; set; }

    public virtual DbSet<VewSysCouncil> VewSysCouncils { get; set; }

    public virtual DbSet<VewSysFc> VewSysFcs { get; set; }

    public virtual DbSet<VewSysFf> VewSysFfs { get; set; }

    public virtual DbSet<VewSysFn> VewSysFns { get; set; }

    public virtual DbSet<VewSysFss> VewSysFsses { get; set; }

    public virtual DbSet<VewSysGk> VewSysGks { get; set; }

    public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }

    public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; }

    public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }

    public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }

    public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }

    public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }

    public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }

    public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }

    public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=sql2k2201.discountasp.net;User ID=SQL2022_1035200_kofcwaorg_user;Password=fAMI7WufRat3F5&aCI0-;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspnetApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId)
                .HasName("PK__aspnet_Applicati__7E8CC4B1")
                .IsClustered(false);

            entity.ToTable("aspnet_Applications");

            entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_Applicati__00750D23").IsUnique();

            entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_Applicati__7F80E8EA").IsUnique();

            entity.HasIndex(e => e.LoweredApplicationName, "aspnet_Applications_Index").IsClustered();

            entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ApplicationName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspnetMembership>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_Membershi__1387E197")
                .IsClustered(false);

            entity.ToTable("aspnet_Membership");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail }, "aspnet_Membership_index").IsClustered();

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredEmail).HasMaxLength(256);
            entity.Property(e => e.MobilePin)
                .HasMaxLength(16)
                .HasColumnName("MobilePIN");
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.PasswordSalt).HasMaxLength(128);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetMemberships)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__Appli__147C05D0");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetMembership)
                .HasForeignKey<AspnetMembership>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Me__UserI__15702A09");
        });

        modelBuilder.Entity<AspnetPath>(entity =>
        {
            entity.HasKey(e => e.PathId)
                .HasName("PK__aspnet_Paths__451F3D2B")
                .IsClustered(false);

            entity.ToTable("aspnet_Paths");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredPath }, "aspnet_Paths_index")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LoweredPath).HasMaxLength(256);
            entity.Property(e => e.Path).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetPaths)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pa__Appli__46136164");
        });

        modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
        {
            entity.HasKey(e => e.PathId).HasName("PK__aspnet_Personali__4AD81681");

            entity.ToTable("aspnet_PersonalizationAllUsers");

            entity.Property(e => e.PathId).ValueGeneratedNever();
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PageSettings).HasColumnType("image");

            entity.HasOne(d => d.Path).WithOne(p => p.AspnetPersonalizationAllUser)
                .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pe__PathI__4BCC3ABA");
        });

        modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK__aspnet_Personali__4DB4832C")
                .IsClustered(false);

            entity.ToTable("aspnet_PersonalizationPerUser");

            entity.HasIndex(e => new { e.PathId, e.UserId }, "aspnet_PersonalizationPerUser_index1")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new { e.UserId, e.PathId }, "aspnet_PersonalizationPerUser_ncindex2").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PageSettings).HasColumnType("image");

            entity.HasOne(d => d.Path).WithMany(p => p.AspnetPersonalizationPerUsers)
                .HasForeignKey(d => d.PathId)
                .HasConstraintName("FK__aspnet_Pe__PathI__4F9CCB9E");

            entity.HasOne(d => d.User).WithMany(p => p.AspnetPersonalizationPerUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__aspnet_Pe__UserI__5090EFD7");
        });

        modelBuilder.Entity<AspnetProfile>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__aspnet_Profile__2882FE7D");

            entity.ToTable("aspnet_Profile");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.PropertyNames).HasColumnType("ntext");
            entity.Property(e => e.PropertyValuesBinary).HasColumnType("image");
            entity.Property(e => e.PropertyValuesString).HasColumnType("ntext");

            entity.HasOne(d => d.User).WithOne(p => p.AspnetProfile)
                .HasForeignKey<AspnetProfile>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Pr__UserI__297722B6");
        });

        modelBuilder.Entity<AspnetRole>(entity =>
        {
            entity.HasKey(e => e.RoleId)
                .HasName("PK__aspnet_Roles__320C68B7")
                .IsClustered(false);

            entity.ToTable("aspnet_Roles");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName }, "aspnet_Roles_index1")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredRoleName).HasMaxLength(256);
            entity.Property(e => e.RoleName).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetRoles)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Ro__Appli__33008CF0");
        });

        modelBuilder.Entity<AspnetSchemaVersion>(entity =>
        {
            entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion }).HasName("PK__aspnet_SchemaVer__090A5324");

            entity.ToTable("aspnet_SchemaVersions");

            entity.Property(e => e.Feature).HasMaxLength(128);
            entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
        });

        modelBuilder.Entity<AspnetUser>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK__aspnet_Users__035179CE")
                .IsClustered(false);

            entity.ToTable("aspnet_Users");

            entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName }, "aspnet_Users_Index")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate }, "aspnet_Users_Index2");

            entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredUserName).HasMaxLength(256);
            entity.Property(e => e.MobileAlias)
                .HasMaxLength(16)
                .HasDefaultValueSql("(null)");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.AspnetUsers)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__aspnet_Us__Appli__04459E07");

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspnetUsersInRole",
                    r => r.HasOne<AspnetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__RoleI__37C5420D"),
                    l => l.HasOne<AspnetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__aspnet_Us__UserI__36D11DD4"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__aspnet_UsersInRo__35DCF99B");
                        j.ToTable("aspnet_UsersInRoles");
                        j.HasIndex(new[] { "RoleId" }, "aspnet_UsersInRoles_index");
                    });
        });

        modelBuilder.Entity<AspnetWebEventEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__aspnet_WebEvent___5FD33367");

            entity.ToTable("aspnet_WebEvent_Events");

            entity.Property(e => e.EventId)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ApplicationPath).HasMaxLength(256);
            entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);
            entity.Property(e => e.Details).HasColumnType("ntext");
            entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");
            entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");
            entity.Property(e => e.EventTime).HasColumnType("datetime");
            entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.EventType).HasMaxLength(256);
            entity.Property(e => e.ExceptionType).HasMaxLength(256);
            entity.Property(e => e.MachineName).HasMaxLength(256);
            entity.Property(e => e.Message).HasMaxLength(1024);
            entity.Property(e => e.RequestUrl).HasMaxLength(1024);
        });

        modelBuilder.Entity<Dtproperty>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Property }).HasName("pk_dtproperties");

            entity.ToTable("dtproperties");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Property)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("property");
            entity.Property(e => e.Lvalue)
                .HasColumnType("image")
                .HasColumnName("lvalue");
            entity.Property(e => e.Objectid).HasColumnName("objectid");
            entity.Property(e => e.Uvalue)
                .HasMaxLength(255)
                .HasColumnName("uvalue");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("value");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<ImportEmail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_ImportEmail");

            entity.Property(e => e.Email).HasMaxLength(200);
        });

        modelBuilder.Entity<QryMemberOffice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryMemberOffice");

            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo1Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo1UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.AddInfo2Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo2UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AddressUpdated).HasColumnType("datetime");
            entity.Property(e => e.AddressUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AltOfficeDescription).HasMaxLength(50);
            entity.Property(e => e.AssemblyUpdated).HasColumnType("datetime");
            entity.Property(e => e.AssemblyUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.BulletinUpdated).HasColumnType("datetime");
            entity.Property(e => e.BulletinUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CanEditAdmUi).HasColumnName("CanEditAdmUI");
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.CellPhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.CellPhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CircleUpdated).HasColumnType("datetime");
            entity.Property(e => e.CircleUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CityUpdated).HasColumnType("datetime");
            entity.Property(e => e.CityUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CouncilUpdated).HasColumnType("datetime");
            entity.Property(e => e.CouncilUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeceasedUpdated).HasColumnType("datetime");
            entity.Property(e => e.DeceasedUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmailUpdated).HasColumnType("datetime");
            entity.Property(e => e.EmailUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FaxNumberUpdated).HasColumnType("datetime");
            entity.Property(e => e.FaxNumberUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FirstNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.FirstNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.KofCid)
                .HasMaxLength(7)
                .HasColumnName("KofCID");
            entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.Mi)
                .HasMaxLength(50)
                .HasColumnName("MI");
            entity.Property(e => e.Miupdated)
                .HasColumnType("datetime")
                .HasColumnName("MIUpdated");
            entity.Property(e => e.MiupdatedBy)
                .HasMaxLength(50)
                .HasColumnName("MIUpdatedBy");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.NickNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.NickNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.OfficeDescription).HasMaxLength(75);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.PaidMpd).HasColumnName("PaidMPD");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.PhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.PostalCodeUpdated).HasColumnType("datetime");
            entity.Property(e => e.PostalCodeUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.PrefixUpdated).HasColumnType("datetime");
            entity.Property(e => e.PrefixUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.StateUpdated).HasColumnType("datetime");
            entity.Property(e => e.StateUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.SuffixUpdated).HasColumnType("datetime");
            entity.Property(e => e.SuffixUpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.WifesName).HasMaxLength(12);
            entity.Property(e => e.WifesNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.WifesNameUpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<QryRptbulletin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryRPTBulletin");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AltOfficeDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.District).HasColumnName("DISTRICT");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FullName)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OfficeDescription)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OfficeId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("OfficeID");
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(20);
        });

        modelBuilder.Entity<QryRptlabelsObsolete20100528>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryRPTLabels_OBSOLETE_20100528");

            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AltOfficeDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.District).HasColumnName("DISTRICT");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OfficeDescription).HasMaxLength(75);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.WifesName).HasMaxLength(12);
        });

        modelBuilder.Entity<QryRptliabIn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryRPTLiabIns");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AltOfficeDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.District).HasColumnName("DISTRICT");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.OfficeDescription).HasMaxLength(50);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(20);
        });

        modelBuilder.Entity<QryRptmemberDataAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryRPTMemberDataAll");

            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AltDescription).HasMaxLength(50);
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.District).HasColumnName("DISTRICT");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OfficeDescription).HasMaxLength(75);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.WifesName).HasMaxLength(12);
        });

        modelBuilder.Entity<QryRptmemberDataAllOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryRPTMemberDataAll_OLD");

            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AltDescription).HasMaxLength(50);
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.District).HasColumnName("DISTRICT");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OfficeDescription).HasMaxLength(75);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.WifesName).HasMaxLength(12);
        });

        modelBuilder.Entity<QryRptmemberDataAllTim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryRPTMemberDataAllTIM");

            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AltDescription).HasMaxLength(50);
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.District).HasColumnName("DISTRICT");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OfficeDescription).HasMaxLength(75);
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.WifesName).HasMaxLength(12);
        });

        modelBuilder.Entity<QryRptrollCallSubDelegate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryRPTRollCallSubDelegates");

            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo11)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 1");
            entity.Property(e => e.AddInfo1Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo1UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.AddInfo21)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 2");
            entity.Property(e => e.AddInfo2Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo2UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AddInfo3)
                .HasMaxLength(50)
                .HasColumnName("ADD INFO 3");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AddressUpdated).HasColumnType("datetime");
            entity.Property(e => e.AddressUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AssemblyUpdated).HasColumnType("datetime");
            entity.Property(e => e.AssemblyUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.BulletinUpdated).HasColumnType("datetime");
            entity.Property(e => e.BulletinUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CLocation)
                .HasMaxLength(50)
                .HasColumnName("C_LOCATION");
            entity.Property(e => e.CName)
                .HasMaxLength(32)
                .HasColumnName("C_NAME");
            entity.Property(e => e.CNumber).HasColumnName("C_NUMBER");
            entity.Property(e => e.CanEditAdmUi).HasColumnName("CanEditAdmUI");
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.CellPhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.CellPhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Chartered).HasColumnType("datetime");
            entity.Property(e => e.CircleUpdated).HasColumnType("datetime");
            entity.Property(e => e.CircleUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CityUpdated).HasColumnType("datetime");
            entity.Property(e => e.CityUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CouncilUpdated).HasColumnType("datetime");
            entity.Property(e => e.CouncilUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeceasedUpdated).HasColumnType("datetime");
            entity.Property(e => e.DeceasedUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.DioceseId)
                .HasMaxLength(3)
                .HasColumnName("DioceseID");
            entity.Property(e => e.District).HasColumnName("DISTRICT");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmailUpdated).HasColumnType("datetime");
            entity.Property(e => e.EmailUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FaxNumberUpdated).HasColumnType("datetime");
            entity.Property(e => e.FaxNumberUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FirstNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.FirstNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.KofCid)
                .HasMaxLength(7)
                .HasColumnName("KofCID");
            entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.Mi)
                .HasMaxLength(50)
                .HasColumnName("MI");
            entity.Property(e => e.Miupdated)
                .HasColumnType("datetime")
                .HasColumnName("MIUpdated");
            entity.Property(e => e.MiupdatedBy)
                .HasMaxLength(50)
                .HasColumnName("MIUpdatedBy");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.NickNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.NickNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.PaidMpd).HasColumnName("PaidMPD");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.PhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.PostalCodeUpdated).HasColumnType("datetime");
            entity.Property(e => e.PostalCodeUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.PrefixUpdated).HasColumnType("datetime");
            entity.Property(e => e.PrefixUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.StateUpdated).HasColumnType("datetime");
            entity.Property(e => e.StateUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.SuffixUpdated).HasColumnType("datetime");
            entity.Property(e => e.SuffixUpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.WifesName).HasMaxLength(12);
            entity.Property(e => e.WifesNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.WifesNameUpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<QryRptrollCallSubOther>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("qryRPTRollCallSubOthers");

            entity.Property(e => e.AddInfo1).HasMaxLength(50);
            entity.Property(e => e.AddInfo2).HasMaxLength(50);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CLocation)
                .HasMaxLength(50)
                .HasColumnName("C_LOCATION");
            entity.Property(e => e.CName)
                .HasMaxLength(32)
                .HasColumnName("C_NAME");
            entity.Property(e => e.CNumber).HasColumnName("C_NUMBER");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.District).HasColumnName("DISTRICT");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.WifesName).HasMaxLength(12);
        });

        modelBuilder.Entity<Roster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("__Roster");

            entity.Property(e => e.Asm).HasColumnName("ASM#");
            entity.Property(e => e.Co).HasColumnName("CO#");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("dob");
            entity.Property(e => e.F13).HasMaxLength(255);
            entity.Property(e => e.F14).HasMaxLength(255);
            entity.Property(e => e.F15).HasMaxLength(255);
            entity.Property(e => e.F16).HasMaxLength(255);
            entity.Property(e => e.F17).HasMaxLength(255);
            entity.Property(e => e.F18).HasMaxLength(255);
            entity.Property(e => e.F20).HasMaxLength(255);
            entity.Property(e => e.F21).HasMaxLength(255);
            entity.Property(e => e.F22).HasMaxLength(255);
            entity.Property(e => e.F5).HasMaxLength(255);
            entity.Property(e => e.Mbr).HasColumnName("MBR#");
            entity.Property(e => e.ReEntryDate)
                .HasMaxLength(255)
                .HasColumnName("re entry date");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .HasColumnName("state");
            entity.Property(e => e.YrsOfService).HasColumnName("Yrs of service");
            entity.Property(e => e._1st)
                .HasColumnType("datetime")
                .HasColumnName("1st");
            entity.Property(e => e._2nd)
                .HasMaxLength(255)
                .HasColumnName("2nd");
            entity.Property(e => e._3rd)
                .HasMaxLength(255)
                .HasColumnName("3rd");
            entity.Property(e => e._4th)
                .HasColumnType("datetime")
                .HasColumnName("4th");
        });

        modelBuilder.Entity<TblArInvoiceDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblAR_InvoiceDetail");

            entity.Property(e => e.Amount).HasColumnType("numeric(14, 2)");
            entity.Property(e => e.Item)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Qty).HasColumnType("numeric(14, 2)");
            entity.Property(e => e.UnitPrice).HasColumnType("numeric(14, 2)");

            entity.HasOne(d => d.InvoiceNumberNavigation).WithMany()
                .HasForeignKey(d => d.InvoiceNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAR_InvoiceDetail_tblAR_InvoiceHeader");

            entity.HasOne(d => d.ItemNavigation).WithMany()
                .HasForeignKey(d => d.Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAR_InvoiceDetail_tblAR_InvoiceItems");
        });

        modelBuilder.Entity<TblArInvoiceHeader>(entity =>
        {
            entity.HasKey(e => e.InvoiceNumber);

            entity.ToTable("tblAR_InvoiceHeader");

            entity.Property(e => e.InvoiceAmount).HasColumnType("numeric(14, 2)");
            entity.Property(e => e.InvoiceBalance).HasColumnType("numeric(14, 2)");
            entity.Property(e => e.InvoiceStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("O")
                .IsFixedLength()
                .HasComment("(O)pen or (C)losed");

            entity.HasOne(d => d.CouncilNavigation).WithMany(p => p.TblArInvoiceHeaders)
                .HasForeignKey(d => d.Council)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAR_InvoiceHeader_tbl_ValCouncils");
        });

        modelBuilder.Entity<TblArInvoiceItem>(entity =>
        {
            entity.HasKey(e => e.Item);

            entity.ToTable("tblAR_InvoiceItems");

            entity.Property(e => e.Item)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UnitPrice).HasColumnType("numeric(14, 2)");
        });

        modelBuilder.Entity<TblArPaymentDetail>(entity =>
        {
            entity.ToTable("tblAR_PaymentDetail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PaymentAmount).HasColumnType("numeric(14, 2)");
            entity.Property(e => e.PaymentReference)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.InvoiceNumberNavigation).WithMany(p => p.TblArPaymentDetails)
                .HasForeignKey(d => d.InvoiceNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAR_PaymentDetail_tblAR_InvoiceHeader");
        });

        modelBuilder.Entity<TblAspnetApplicationsTemp>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK_aspnet_Applications_TEMP");

            entity.ToTable("TBL_aspnet_Applications_TEMP");

            entity.Property(e => e.ApplicationId).ValueGeneratedNever();
            entity.Property(e => e.ApplicationName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
        });

        modelBuilder.Entity<TblAspnetMmembershipTemp>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.UserId });

            entity.ToTable("tbl_aspnet_Mmembership_TEMP");

            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredEmail).HasMaxLength(256);
            entity.Property(e => e.MobilePin)
                .HasMaxLength(16)
                .HasColumnName("MobilePIN");
            entity.Property(e => e.Password).HasMaxLength(128);
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.PasswordSalt).HasMaxLength(128);
        });

        modelBuilder.Entity<TblAspnetRolesTemp>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK_aspnet_Roles_TEMP");

            entity.ToTable("TBL_aspnet_Roles_TEMP");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredRoleName).HasMaxLength(256);
            entity.Property(e => e.RoleName).HasMaxLength(256);

            entity.HasOne(d => d.Application).WithMany(p => p.TblAspnetRolesTemps)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_aspnet_Roles_TEMP_aspnet_Applications_TEMP");
        });

        modelBuilder.Entity<TblCorrDddistrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_CorrDDDistrict");

            entity.Property(e => e.DdmemberId).HasColumnName("DDMemberID");
        });

        modelBuilder.Entity<TblCorrGroupOffice>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.OfficeId })
                .HasName("aaaaatbl_CorrGroupOffice_PK")
                .IsClustered(false);

            entity.ToTable("tbl_CorrGroupOffice");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.BegFratYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Group).WithMany(p => p.TblCorrGroupOffices)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CorrGroupOffice_tbl_ValGroups");

            entity.HasOne(d => d.Office).WithMany(p => p.TblCorrGroupOffices)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CorrGroupOffice_tbl_ValOffices");
        });

        modelBuilder.Entity<TblCorrGroupOfficeHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_CorrGroupOffice_History");

            entity.Property(e => e.BegFratYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
        });

        modelBuilder.Entity<TblCorrMemberGroup>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.GroupId })
                .HasName("aaaaatbl_CorrMemberGroup_PK")
                .IsClustered(false);

            entity.ToTable("tbl_CorrMemberGroup", tb =>
                {
                    tb.HasTrigger("T_tbl_CorrMemberGroup_ITrig");
                    tb.HasTrigger("T_tbl_CorrMemberGroup_UTrig");
                });

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");

            entity.HasOne(d => d.Group).WithMany(p => p.TblCorrMemberGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CorrMemberGroup_tbl_ValGroups");

            entity.HasOne(d => d.GroupNavigation).WithMany(p => p.TblCorrMemberGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CorrMemberGroup_tblWSC_ValGroups");

            entity.HasOne(d => d.Member).WithMany(p => p.TblCorrMemberGroups)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_tbl_CorrMemberGroup_tbl_MasMembers");
        });

        modelBuilder.Entity<TblCorrMemberGroup2010Obsolete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_CorrMemberGroup_2010_OBSOLETE");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
        });

        modelBuilder.Entity<TblCorrMemberGroupHistory>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.GroupId, e.BegFratYear });

            entity.ToTable("tbl_CorrMemberGroup_History");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
        });

        modelBuilder.Entity<TblCorrMemberOffice>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.OfficeId })
                .HasName("aaaaatbl_CorrMemberOffice_PK")
                .IsClustered(false);

            entity.ToTable("tbl_CorrMemberOffice", tb =>
                {
                    tb.HasTrigger("T_tbl_CorrMemberOffice_IMember");
                    tb.HasTrigger("T_tbl_CorrMemberOffice_ITrig");
                    tb.HasTrigger("T_tbl_CorrMemberOffice_UMember");
                    tb.HasTrigger("T_tbl_CorrMemberOffice_UTrig");
                });

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

            entity.HasOne(d => d.Member).WithMany(p => p.TblCorrMemberOffices)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_tbl_CorrMemberOffice_tbl_MasMembers");

            entity.HasOne(d => d.Office).WithMany(p => p.TblCorrMemberOffices)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_CorrMemberOffice_tbl_ValOffices");
        });

        modelBuilder.Entity<TblCorrMemberOffice2010Obsolete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_CorrMemberOffice_2010_OBSOLETE");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
        });

        modelBuilder.Entity<TblCorrMemberOfficeHistory>(entity =>
        {
            entity.HasKey(e => new { e.MemberId, e.OfficeId, e.BegFratYear });

            entity.ToTable("tbl_CorrMemberOffice_History");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
        });

        modelBuilder.Entity<TblCvnControl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblCVN_Control");

            entity.Property(e => e.LocationString)
                .HasMaxLength(1000)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblMasMember>(entity =>
        {
            entity.HasKey(e => e.MemberId);

            entity.ToTable("tbl_MasMembers", tb =>
                {
                    tb.HasTrigger("T_tbl_MasMembers_DTrig");
                    tb.HasTrigger("T_tbl_MasMembers_U1Trig");
                    tb.HasTrigger("T_tbl_MasMembers_UTrig");
                });

            entity.HasIndex(e => e.KofCid, "NonClusteredIndex-20130527-110545").IsUnique();

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo1Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo1UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.AddInfo2Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo2UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AddressUpdated).HasColumnType("datetime");
            entity.Property(e => e.AddressUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AssemblyUpdated).HasColumnType("datetime");
            entity.Property(e => e.AssemblyUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Bulletin).HasDefaultValue(false);
            entity.Property(e => e.BulletinUpdated).HasColumnType("datetime");
            entity.Property(e => e.BulletinUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CanEditAdmUi).HasColumnName("CanEditAdmUI");
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.CellPhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.CellPhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CircleUpdated).HasColumnType("datetime");
            entity.Property(e => e.CircleUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CityUpdated).HasColumnType("datetime");
            entity.Property(e => e.CityUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CouncilUpdated).HasColumnType("datetime");
            entity.Property(e => e.CouncilUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Deceased).HasDefaultValue(false);
            entity.Property(e => e.DeceasedUpdated).HasColumnType("datetime");
            entity.Property(e => e.DeceasedUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmailUpdated).HasColumnType("datetime");
            entity.Property(e => e.EmailUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FaxNumberUpdated).HasColumnType("datetime");
            entity.Property(e => e.FaxNumberUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FirstNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.FirstNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.KofCid)
                .HasMaxLength(7)
                .HasColumnName("KofCID");
            entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Mi)
                .HasMaxLength(50)
                .HasColumnName("MI");
            entity.Property(e => e.Miupdated)
                .HasColumnType("datetime")
                .HasColumnName("MIUpdated");
            entity.Property(e => e.MiupdatedBy)
                .HasMaxLength(50)
                .HasColumnName("MIUpdatedBy");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.NickNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.NickNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.PaidMpd)
                .HasDefaultValue(false)
                .HasColumnName("PaidMPD");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.PhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.PostalCodeUpdated).HasColumnType("datetime");
            entity.Property(e => e.PostalCodeUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.PrefixUpdated).HasColumnType("datetime");
            entity.Property(e => e.PrefixUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.StateUpdated).HasColumnType("datetime");
            entity.Property(e => e.StateUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.SuffixUpdated).HasColumnType("datetime");
            entity.Property(e => e.SuffixUpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.WhyDoNotEmail).IsUnicode(false);
            entity.Property(e => e.WifesName).HasMaxLength(12);
            entity.Property(e => e.WifesNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.WifesNameUpdatedBy).HasMaxLength(100);

            entity.HasOne(d => d.AssemblyNavigation).WithMany(p => p.TblMasMembers)
                .HasForeignKey(d => d.Assembly)
                .HasConstraintName("FK_tbl_MasMembers_tbl_ValAssys");

            entity.HasOne(d => d.CircleNavigation).WithMany(p => p.TblMasMembers)
                .HasForeignKey(d => d.Circle)
                .HasConstraintName("FK_tbl_MasMembers_tbl_ValCircles");

            entity.HasOne(d => d.CouncilNavigation).WithMany(p => p.TblMasMembers)
                .HasForeignKey(d => d.Council)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_MasMembers_tbl_ValCouncils");
        });

        modelBuilder.Entity<TblMasMembersArchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MasMembersArchive");

            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo1Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo1UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.AddInfo2Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo2UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AddressUpdated).HasColumnType("datetime");
            entity.Property(e => e.AddressUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AssemblyUpdated).HasColumnType("datetime");
            entity.Property(e => e.AssemblyUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.BulletinUpdated).HasColumnType("datetime");
            entity.Property(e => e.BulletinUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.CellPhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.CellPhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CircleUpdated).HasColumnType("datetime");
            entity.Property(e => e.CircleUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CityUpdated).HasColumnType("datetime");
            entity.Property(e => e.CityUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CouncilUpdated).HasColumnType("datetime");
            entity.Property(e => e.CouncilUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeceasedUpdated).HasColumnType("datetime");
            entity.Property(e => e.DeceasedUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmailUpdated).HasColumnType("datetime");
            entity.Property(e => e.EmailUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FaxNumberUpdated).HasColumnType("datetime");
            entity.Property(e => e.FaxNumberUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FirstNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.FirstNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.KofCid)
                .HasMaxLength(7)
                .HasColumnName("KofCID");
            entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MemberID");
            entity.Property(e => e.Mi)
                .HasMaxLength(50)
                .HasColumnName("MI");
            entity.Property(e => e.Miupdated)
                .HasColumnType("datetime")
                .HasColumnName("MIUpdated");
            entity.Property(e => e.MiupdatedBy)
                .HasMaxLength(50)
                .HasColumnName("MIUpdatedBy");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.NickNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.NickNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.PaidMpd).HasColumnName("PaidMPD");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.PhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.PostalCodeUpdated).HasColumnType("datetime");
            entity.Property(e => e.PostalCodeUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.PrefixUpdated).HasColumnType("datetime");
            entity.Property(e => e.PrefixUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.StateUpdated).HasColumnType("datetime");
            entity.Property(e => e.StateUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.SuffixUpdated).HasColumnType("datetime");
            entity.Property(e => e.SuffixUpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.WifesName).HasMaxLength(12);
            entity.Property(e => e.WifesNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.WifesNameUpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblMasMembersTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MasMembersTest");

            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo1Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo1UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.AddInfo2Updated).HasColumnType("datetime");
            entity.Property(e => e.AddInfo2UpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AddressUpdated).HasColumnType("datetime");
            entity.Property(e => e.AddressUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.AssemblyUpdated).HasColumnType("datetime");
            entity.Property(e => e.AssemblyUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.BulletinUpdated).HasColumnType("datetime");
            entity.Property(e => e.BulletinUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CanEditAdmUi).HasColumnName("CanEditAdmUI");
            entity.Property(e => e.CellPhone).HasMaxLength(50);
            entity.Property(e => e.CellPhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.CellPhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CircleUpdated).HasColumnType("datetime");
            entity.Property(e => e.CircleUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CityUpdated).HasColumnType("datetime");
            entity.Property(e => e.CityUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.CouncilUpdated).HasColumnType("datetime");
            entity.Property(e => e.CouncilUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeceasedUpdated).HasColumnType("datetime");
            entity.Property(e => e.DeceasedUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmailUpdated).HasColumnType("datetime");
            entity.Property(e => e.EmailUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FaxNumberUpdated).HasColumnType("datetime");
            entity.Property(e => e.FaxNumberUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.FirstNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.FirstNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.KofCid)
                .HasMaxLength(7)
                .HasColumnName("KofCID");
            entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.LastNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.MemberId)
                .ValueGeneratedOnAdd()
                .HasColumnName("MemberID");
            entity.Property(e => e.Mi)
                .HasMaxLength(50)
                .HasColumnName("MI");
            entity.Property(e => e.Miupdated)
                .HasColumnType("datetime")
                .HasColumnName("MIUpdated");
            entity.Property(e => e.MiupdatedBy)
                .HasMaxLength(50)
                .HasColumnName("MIUpdatedBy");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.NickNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.NickNameUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.PaidMpd).HasColumnName("PaidMPD");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PhoneUpdated).HasColumnType("datetime");
            entity.Property(e => e.PhoneUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.PostalCodeUpdated).HasColumnType("datetime");
            entity.Property(e => e.PostalCodeUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.PrefixUpdated).HasColumnType("datetime");
            entity.Property(e => e.PrefixUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.StateUpdated).HasColumnType("datetime");
            entity.Property(e => e.StateUpdatedBy).HasMaxLength(100);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.SuffixUpdated).HasColumnType("datetime");
            entity.Property(e => e.SuffixUpdatedBy).HasMaxLength(10);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.WifesName).HasMaxLength(12);
            entity.Property(e => e.WifesNameUpdated).HasColumnType("datetime");
            entity.Property(e => e.WifesNameUpdatedBy).HasMaxLength(100);
        });

        modelBuilder.Entity<TblMasMileage>(entity =>
        {
            entity.HasKey(e => e.CNumber)
                .HasName("aaaaatbl_MasMileage_PK")
                .IsClustered(false);

            entity.ToTable("tbl_MasMileage");

            entity.Property(e => e.CNumber)
                .ValueGeneratedNever()
                .HasColumnName("C_Number");
            entity.Property(e => e.Bellevue).HasColumnName("BELLEVUE");
            entity.Property(e => e.Bellingham).HasColumnName("BELLINGHAM");
            entity.Property(e => e.Bremerton).HasColumnName("BREMERTON");
            entity.Property(e => e.Everett).HasColumnName("EVERETT");
            entity.Property(e => e.Kennewick).HasColumnName("KENNEWICK");
            entity.Property(e => e.Lynnwood).HasColumnName("LYNNWOOD");
            entity.Property(e => e.Moseslake).HasColumnName("MOSESLAKE");
            entity.Property(e => e.Olympia).HasColumnName("OLYMPIA");
            entity.Property(e => e.Pasco).HasColumnName("PASCO");
            entity.Property(e => e.Richland).HasColumnName("RICHLAND");
            entity.Property(e => e.Seattle).HasColumnName("SEATTLE");
            entity.Property(e => e.Spokane).HasColumnName("SPOKANE");
            entity.Property(e => e.Tacoma).HasColumnName("TACOMA");
            entity.Property(e => e.Tukwila).HasColumnName("TUKWILA");
            entity.Property(e => e.Vancouver).HasColumnName("VANCOUVER");
            entity.Property(e => e.Wenatchee).HasColumnName("WENATCHEE");
            entity.Property(e => e.Yakima).HasColumnName("YAKIMA");
        });

        modelBuilder.Entity<TblMemTrxDirChange>(entity =>
        {
            entity.ToTable("tblMEM_trxDirChange");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.KofCid)
                .HasMaxLength(7)
                .HasColumnName("KofCID");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Mi)
                .HasMaxLength(50)
                .HasColumnName("MI");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(5);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.WifesName).HasMaxLength(12);

            entity.HasOne(d => d.CouncilNavigation).WithMany(p => p.TblMemTrxDirChanges)
                .HasForeignKey(d => d.Council)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMEM_trxDirChange_tbl_ValCouncils");

            entity.HasOne(d => d.KofC).WithMany(p => p.TblMemTrxDirChanges)
                .HasPrincipalKey(p => p.KofCid)
                .HasForeignKey(d => d.KofCid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMEM_trxDirChange_tbl_MasMembers");

            entity.HasOne(d => d.Office).WithMany(p => p.TblMemTrxDirChanges)
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblMEM_trxDirChange_tbl_ValOffices");
        });

        modelBuilder.Entity<TblMsrReportPeriod>(entity =>
        {
            entity.ToTable("tblMSR_ReportPeriod");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Period)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PeriodText)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblRpt4wavItem>(entity =>
        {
            entity.HasKey(e => e.Gkfn);

            entity.ToTable("tblRPT_4WavItems");

            entity.Property(e => e.Gkfn).HasColumnName("GKFN");
            entity.Property(e => e.Comments)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ExemDate).HasColumnType("datetime");
            entity.Property(e => e.ExemLocCity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExemLocState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FirstDegDate).HasColumnType("datetime");
            entity.Property(e => e.MasterName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MemberNo)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Province)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReqFor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RptId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RptID");
            entity.Property(e => e.Rpttype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RPTType");
            entity.Property(e => e.SendersEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecialCircum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblRptDirChangeItem>(entity =>
        {
            entity.HasKey(e => e.Gkfn);

            entity.ToTable("tblRPT_DirChangeItems");

            entity.Property(e => e.Gkfn).HasColumnName("GKFN");
            entity.Property(e => e.EntityName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntityNumber).HasDefaultValue(0);
            entity.Property(e => e.EntityType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ind1Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind1City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind1Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind1Fax)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Ind1FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind1KofCid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ind1KofCID");
            entity.Property(e => e.Ind1LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind1Mi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Ind1MI");
            entity.Property(e => e.Ind1Phone)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Ind1State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ind1Type)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ind1WifesName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind1Zip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ind2Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind2City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind2Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind2Fax)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Ind2FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind2KofCid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ind2KofCID");
            entity.Property(e => e.Ind2LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind2Mi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("Ind2MI");
            entity.Property(e => e.Ind2Phone)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Ind2State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ind2Type)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ind2WifesName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ind2Zip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Miwhen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MIWhen");
            entity.Property(e => e.Miwhere)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MIWhere");
            entity.Property(e => e.RptId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RptID");
            entity.Property(e => e.SendersEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SendersName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblRptMasItem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRPT_MasItems");

            entity.Property(e => e.ItemDescr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemId)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rpttype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RPTType");
        });

        modelBuilder.Entity<TblRptTrxReportItem>(entity =>
        {
            entity.HasKey(e => new { e.Rpttype, e.Council, e.RptYear, e.RptPeriod });

            entity.ToTable("tblRPT_TrxReportItems");

            entity.Property(e => e.Rpttype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RPTType");
            entity.Property(e => e.Cm1).HasColumnName("CM1");
            entity.Property(e => e.Cm10).HasColumnName("CM10");
            entity.Property(e => e.Cm11).HasColumnName("CM11");
            entity.Property(e => e.Cm12).HasColumnName("CM12");
            entity.Property(e => e.Cm13).HasColumnName("CM13");
            entity.Property(e => e.Cm14).HasColumnName("CM14");
            entity.Property(e => e.Cm15).HasColumnName("CM15");
            entity.Property(e => e.Cm16).HasColumnName("CM16");
            entity.Property(e => e.Cm17).HasColumnName("CM17");
            entity.Property(e => e.Cm2).HasColumnName("CM2");
            entity.Property(e => e.Cm3).HasColumnName("CM3");
            entity.Property(e => e.Cm4).HasColumnName("CM4");
            entity.Property(e => e.Cm5).HasColumnName("CM5");
            entity.Property(e => e.Cm6).HasColumnName("CM6");
            entity.Property(e => e.Cm7).HasColumnName("CM7");
            entity.Property(e => e.Cm8).HasColumnName("CM8");
            entity.Property(e => e.Cm9).HasColumnName("CM9");
            entity.Property(e => e.Cmm1)
                .HasColumnType("text")
                .HasColumnName("CMM1");
            entity.Property(e => e.Cmm2)
                .HasColumnType("text")
                .HasColumnName("CMM2");
            entity.Property(e => e.Cmm3)
                .HasColumnType("text")
                .HasColumnName("CMM3");
            entity.Property(e => e.Cmm4)
                .HasColumnType("text")
                .HasColumnName("CMM4");
            entity.Property(e => e.Cmm5)
                .HasColumnType("text")
                .HasColumnName("CMM5");
            entity.Property(e => e.Cmm6)
                .HasColumnType("text")
                .HasColumnName("CMM6");
            entity.Property(e => e.Cmm7)
                .HasColumnType("text")
                .HasColumnName("CMM7");
            entity.Property(e => e.Cmm8)
                .HasColumnType("text")
                .HasColumnName("CMM8");
            entity.Property(e => e.Cmm9)
                .HasColumnType("text")
                .HasColumnName("CMM9");
            entity.Property(e => e.Cmt1)
                .HasMaxLength(300)
                .HasColumnName("CMT1");
            entity.Property(e => e.Cmt2)
                .HasMaxLength(300)
                .HasColumnName("CMT2");
            entity.Property(e => e.Cmt3)
                .HasMaxLength(300)
                .HasColumnName("CMT3");
            entity.Property(e => e.Cmt4)
                .HasMaxLength(300)
                .HasColumnName("CMT4");
            entity.Property(e => e.DateEntered).HasColumnType("datetime");
            entity.Property(e => e.EmailTo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fa1).HasColumnName("FA1");
            entity.Property(e => e.Fa10).HasColumnName("FA10");
            entity.Property(e => e.Fa11).HasColumnName("FA11");
            entity.Property(e => e.Fa12).HasColumnName("FA12");
            entity.Property(e => e.Fa13).HasColumnName("FA13");
            entity.Property(e => e.Fa14).HasColumnName("FA14");
            entity.Property(e => e.Fa2).HasColumnName("FA2");
            entity.Property(e => e.Fa3).HasColumnName("FA3");
            entity.Property(e => e.Fa4).HasColumnName("FA4");
            entity.Property(e => e.Fa5).HasColumnName("FA5");
            entity.Property(e => e.Fa6).HasColumnName("FA6");
            entity.Property(e => e.Fa7).HasColumnName("FA7");
            entity.Property(e => e.Fa8).HasColumnName("FA8");
            entity.Property(e => e.Fa9).HasColumnName("FA9");
            entity.Property(e => e.Fam1)
                .HasColumnType("text")
                .HasColumnName("FAM1");
            entity.Property(e => e.Fam2)
                .HasColumnType("text")
                .HasColumnName("FAM2");
            entity.Property(e => e.Fam3)
                .HasColumnType("text")
                .HasColumnName("FAM3");
            entity.Property(e => e.Fam4)
                .HasColumnType("text")
                .HasColumnName("FAM4");
            entity.Property(e => e.Fam5)
                .HasColumnType("text")
                .HasColumnName("FAM5");
            entity.Property(e => e.Fam6)
                .HasColumnType("text")
                .HasColumnName("FAM6");
            entity.Property(e => e.Fam7)
                .HasColumnType("text")
                .HasColumnName("FAM7");
            entity.Property(e => e.Fam8)
                .HasColumnType("text")
                .HasColumnName("FAM8");
            entity.Property(e => e.Fam9)
                .HasColumnType("text")
                .HasColumnName("FAM9");
            entity.Property(e => e.Fat1)
                .HasMaxLength(300)
                .HasColumnName("FAT1");
            entity.Property(e => e.Fat2)
                .HasMaxLength(300)
                .HasColumnName("FAT2");
            entity.Property(e => e.Fp1).HasColumnName("FP1");
            entity.Property(e => e.Fp10).HasColumnName("FP10");
            entity.Property(e => e.Fp11).HasColumnName("FP11");
            entity.Property(e => e.Fp2).HasColumnName("FP2");
            entity.Property(e => e.Fp3).HasColumnName("FP3");
            entity.Property(e => e.Fp4).HasColumnName("FP4");
            entity.Property(e => e.Fp5).HasColumnName("FP5");
            entity.Property(e => e.Fp6).HasColumnName("FP6");
            entity.Property(e => e.Fp7).HasColumnName("FP7");
            entity.Property(e => e.Fp8).HasColumnName("FP8");
            entity.Property(e => e.Fp9).HasColumnName("FP9");
            entity.Property(e => e.Fpm1)
                .HasColumnType("text")
                .HasColumnName("FPM1");
            entity.Property(e => e.Fpm2)
                .HasColumnType("text")
                .HasColumnName("FPM2");
            entity.Property(e => e.Fpm3)
                .HasColumnType("text")
                .HasColumnName("FPM3");
            entity.Property(e => e.Fpm4)
                .HasColumnType("text")
                .HasColumnName("FPM4");
            entity.Property(e => e.Fpm5)
                .HasColumnType("text")
                .HasColumnName("FPM5");
            entity.Property(e => e.Fpm6)
                .HasColumnType("text")
                .HasColumnName("FPM6");
            entity.Property(e => e.Fpm7)
                .HasColumnType("text")
                .HasColumnName("FPM7");
            entity.Property(e => e.Fpm8)
                .HasColumnType("text")
                .HasColumnName("FPM8");
            entity.Property(e => e.Fpm9)
                .HasColumnType("text")
                .HasColumnName("FPM9");
            entity.Property(e => e.FromChairman)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gkfn)
                .ValueGeneratedOnAdd()
                .HasColumnName("GKFN");
            entity.Property(e => e.Lp1).HasColumnName("LP1");
            entity.Property(e => e.Lp10).HasColumnName("LP10");
            entity.Property(e => e.Lp11).HasColumnName("LP11");
            entity.Property(e => e.Lp12).HasColumnName("LP12");
            entity.Property(e => e.Lp13).HasColumnName("LP13");
            entity.Property(e => e.Lp14).HasColumnName("LP14");
            entity.Property(e => e.Lp15).HasColumnName("LP15");
            entity.Property(e => e.Lp2).HasColumnName("LP2");
            entity.Property(e => e.Lp3).HasColumnName("LP3");
            entity.Property(e => e.Lp4).HasColumnName("LP4");
            entity.Property(e => e.Lp5).HasColumnName("LP5");
            entity.Property(e => e.Lp6).HasColumnName("LP6");
            entity.Property(e => e.Lp7).HasColumnName("LP7");
            entity.Property(e => e.Lp8).HasColumnName("LP8");
            entity.Property(e => e.Lp9).HasColumnName("LP9");
            entity.Property(e => e.Lpm1)
                .HasColumnType("text")
                .HasColumnName("LPM1");
            entity.Property(e => e.Lpm2)
                .HasColumnType("text")
                .HasColumnName("LPM2");
            entity.Property(e => e.Lpm3)
                .HasColumnType("text")
                .HasColumnName("LPM3");
            entity.Property(e => e.Lpm4)
                .HasColumnType("text")
                .HasColumnName("LPM4");
            entity.Property(e => e.Lpm5)
                .HasColumnType("text")
                .HasColumnName("LPM5");
            entity.Property(e => e.Lpm6)
                .HasColumnType("text")
                .HasColumnName("LPM6");
            entity.Property(e => e.Lpm7)
                .HasColumnType("text")
                .HasColumnName("LPM7");
            entity.Property(e => e.Lpm8)
                .HasColumnType("text")
                .HasColumnName("LPM8");
            entity.Property(e => e.Lpm9)
                .HasColumnType("text")
                .HasColumnName("LPM9");
            entity.Property(e => e.Ma1).HasColumnName("MA1");
            entity.Property(e => e.Ma10).HasColumnName("MA10");
            entity.Property(e => e.Ma11).HasColumnName("MA11");
            entity.Property(e => e.Ma12).HasColumnName("MA12");
            entity.Property(e => e.Ma13).HasColumnName("MA13");
            entity.Property(e => e.Ma14).HasColumnName("MA14");
            entity.Property(e => e.Ma15).HasColumnName("MA15");
            entity.Property(e => e.Ma2).HasColumnName("MA2");
            entity.Property(e => e.Ma3).HasColumnName("MA3");
            entity.Property(e => e.Ma4).HasColumnName("MA4");
            entity.Property(e => e.Ma5).HasColumnName("MA5");
            entity.Property(e => e.Ma6).HasColumnName("MA6");
            entity.Property(e => e.Ma7).HasColumnName("MA7");
            entity.Property(e => e.Ma8).HasColumnName("MA8");
            entity.Property(e => e.Ma9).HasColumnName("MA9");
            entity.Property(e => e.RptId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RptID");
            entity.Property(e => e.Sp1).HasColumnName("SP1");
            entity.Property(e => e.Sp10).HasColumnName("SP10");
            entity.Property(e => e.Sp2).HasColumnName("SP2");
            entity.Property(e => e.Sp3).HasColumnName("SP3");
            entity.Property(e => e.Sp4).HasColumnName("SP4");
            entity.Property(e => e.Sp5).HasColumnName("SP5");
            entity.Property(e => e.Sp6).HasColumnName("SP6");
            entity.Property(e => e.Sp7).HasColumnName("SP7");
            entity.Property(e => e.Sp8).HasColumnName("SP8");
            entity.Property(e => e.Sp9).HasColumnName("SP9");
            entity.Property(e => e.Spt1)
                .HasMaxLength(300)
                .HasColumnName("SPT1");
            entity.Property(e => e.Spt2)
                .HasMaxLength(300)
                .HasColumnName("SPT2");
            entity.Property(e => e.Status)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblRptTrxReportItemsSave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblRPT_TrxReportItems_SAVE");

            entity.Property(e => e.Ch1).HasColumnName("CH1");
            entity.Property(e => e.Ch1a).HasColumnName("CH1a");
            entity.Property(e => e.Ch2).HasColumnName("CH2");
            entity.Property(e => e.Ch2a).HasColumnName("CH2a");
            entity.Property(e => e.Ch3).HasColumnName("CH3");
            entity.Property(e => e.Ch3a).HasColumnName("CH3a");
            entity.Property(e => e.Chm)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("CHM");
            entity.Property(e => e.Cm1).HasColumnName("CM1");
            entity.Property(e => e.Cm10).HasColumnName("CM10");
            entity.Property(e => e.Cm10a).HasColumnName("CM10a");
            entity.Property(e => e.Cm1a).HasColumnName("CM1a");
            entity.Property(e => e.Cm2).HasColumnName("CM2");
            entity.Property(e => e.Cm2a).HasColumnName("CM2a");
            entity.Property(e => e.Cm3).HasColumnName("CM3");
            entity.Property(e => e.Cm3a).HasColumnName("CM3a");
            entity.Property(e => e.Cm4).HasColumnName("CM4");
            entity.Property(e => e.Cm4a).HasColumnName("CM4a");
            entity.Property(e => e.Cm5).HasColumnName("CM5");
            entity.Property(e => e.Cm5a).HasColumnName("CM5a");
            entity.Property(e => e.Cm6).HasColumnName("CM6");
            entity.Property(e => e.Cm6a).HasColumnName("CM6a");
            entity.Property(e => e.Cm7).HasColumnName("CM7");
            entity.Property(e => e.Cm7a).HasColumnName("CM7a");
            entity.Property(e => e.Cm8).HasColumnName("CM8");
            entity.Property(e => e.Cm8a).HasColumnName("CM8a");
            entity.Property(e => e.Cm9).HasColumnName("CM9");
            entity.Property(e => e.Cm9a).HasColumnName("CM9a");
            entity.Property(e => e.Cmm)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("CMM");
            entity.Property(e => e.Cp1).HasColumnName("CP1");
            entity.Property(e => e.Cp10).HasColumnName("CP10");
            entity.Property(e => e.Cp11).HasColumnName("CP11");
            entity.Property(e => e.Cp12).HasColumnName("CP12");
            entity.Property(e => e.Cp2).HasColumnName("CP2");
            entity.Property(e => e.Cp3).HasColumnName("CP3");
            entity.Property(e => e.Cp4).HasColumnName("CP4");
            entity.Property(e => e.Cp5).HasColumnName("CP5");
            entity.Property(e => e.Cp6).HasColumnName("CP6");
            entity.Property(e => e.Cp7).HasColumnName("CP7");
            entity.Property(e => e.Cp8).HasColumnName("CP8");
            entity.Property(e => e.Cp9).HasColumnName("CP9");
            entity.Property(e => e.Cpm)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("CPM");
            entity.Property(e => e.DateEntered).HasColumnType("datetime");
            entity.Property(e => e.EmailTo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fp1).HasColumnName("FP1");
            entity.Property(e => e.Fp10).HasColumnName("FP10");
            entity.Property(e => e.Fp2).HasColumnName("FP2");
            entity.Property(e => e.Fp3).HasColumnName("FP3");
            entity.Property(e => e.Fp4).HasColumnName("FP4");
            entity.Property(e => e.Fp5).HasColumnName("FP5");
            entity.Property(e => e.Fp6).HasColumnName("FP6");
            entity.Property(e => e.Fp7).HasColumnName("FP7");
            entity.Property(e => e.Fp8).HasColumnName("FP8");
            entity.Property(e => e.Fp9).HasColumnName("FP9");
            entity.Property(e => e.Fpm)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("FPM");
            entity.Property(e => e.FromChairman)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gkfn)
                .ValueGeneratedOnAdd()
                .HasColumnName("GKFN");
            entity.Property(e => e.Ma1).HasColumnName("MA1");
            entity.Property(e => e.Ma10).HasColumnName("MA10");
            entity.Property(e => e.Ma10a).HasColumnName("MA10a");
            entity.Property(e => e.Ma1a).HasColumnName("MA1a");
            entity.Property(e => e.Ma2).HasColumnName("MA2");
            entity.Property(e => e.Ma2a).HasColumnName("MA2a");
            entity.Property(e => e.Ma3).HasColumnName("MA3");
            entity.Property(e => e.Ma3a).HasColumnName("MA3a");
            entity.Property(e => e.Ma4).HasColumnName("MA4");
            entity.Property(e => e.Ma4a).HasColumnName("MA4a");
            entity.Property(e => e.Ma5).HasColumnName("MA5");
            entity.Property(e => e.Ma5a).HasColumnName("MA5a");
            entity.Property(e => e.Ma6).HasColumnName("MA6");
            entity.Property(e => e.Ma6a).HasColumnName("MA6a");
            entity.Property(e => e.Ma7).HasColumnName("MA7");
            entity.Property(e => e.Ma7a).HasColumnName("MA7a");
            entity.Property(e => e.Ma8).HasColumnName("MA8");
            entity.Property(e => e.Ma8a).HasColumnName("MA8a");
            entity.Property(e => e.Ma9).HasColumnName("MA9");
            entity.Property(e => e.Ma9a).HasColumnName("MA9a");
            entity.Property(e => e.Mam)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("MAM");
            entity.Property(e => e.Pl1).HasColumnName("PL1");
            entity.Property(e => e.Pl10).HasColumnName("PL10");
            entity.Property(e => e.Pl2).HasColumnName("PL2");
            entity.Property(e => e.Pl3).HasColumnName("PL3");
            entity.Property(e => e.Pl4).HasColumnName("PL4");
            entity.Property(e => e.Pl5).HasColumnName("PL5");
            entity.Property(e => e.Pl6).HasColumnName("PL6");
            entity.Property(e => e.Pl7).HasColumnName("PL7");
            entity.Property(e => e.Pl8).HasColumnName("PL8");
            entity.Property(e => e.Pl9).HasColumnName("PL9");
            entity.Property(e => e.Plm)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("PLM");
            entity.Property(e => e.RptId).HasColumnName("RptID");
            entity.Property(e => e.Rpttype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RPTType");
            entity.Property(e => e.Status)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Vp1).HasColumnName("VP1");
            entity.Property(e => e.Vp10).HasColumnName("VP10");
            entity.Property(e => e.Vp2).HasColumnName("VP2");
            entity.Property(e => e.Vp2a).HasColumnName("VP2a");
            entity.Property(e => e.Vp2b)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("VP2b");
            entity.Property(e => e.Vp3).HasColumnName("VP3");
            entity.Property(e => e.Vp4).HasColumnName("VP4");
            entity.Property(e => e.Vp5).HasColumnName("VP5");
            entity.Property(e => e.Vp6).HasColumnName("VP6");
            entity.Property(e => e.Vp7).HasColumnName("VP7");
            entity.Property(e => e.Vp8).HasColumnName("VP8");
            entity.Property(e => e.Vp9).HasColumnName("VP9");
            entity.Property(e => e.Vpm)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("VPM");
            entity.Property(e => e.Yp1).HasColumnName("YP1");
            entity.Property(e => e.Yp10).HasColumnName("YP10");
            entity.Property(e => e.Yp2).HasColumnName("YP2");
            entity.Property(e => e.Yp3).HasColumnName("YP3");
            entity.Property(e => e.Yp4).HasColumnName("YP4");
            entity.Property(e => e.Yp5).HasColumnName("YP5");
            entity.Property(e => e.Yp6).HasColumnName("YP6");
            entity.Property(e => e.Yp7).HasColumnName("YP7");
            entity.Property(e => e.Yp8).HasColumnName("YP8");
            entity.Property(e => e.Yp9).HasColumnName("YP9");
            entity.Property(e => e.Ypm)
                .HasMaxLength(900)
                .IsUnicode(false)
                .HasColumnName("YPM");
        });

        modelBuilder.Entity<TblRptValMsrtype>(entity =>
        {
            entity.HasKey(e => e.Msrtype);

            entity.ToTable("tblRPT_ValMSRType");

            entity.Property(e => e.Msrtype)
                .ValueGeneratedNever()
                .HasColumnName("MSRType");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblRptValReportType>(entity =>
        {
            entity.HasKey(e => e.Rpttype);

            entity.ToTable("tblRPT_ValReportTypes");

            entity.Property(e => e.Rpttype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RPTType");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gkfn)
                .ValueGeneratedOnAdd()
                .HasColumnName("GKFN");
        });

        modelBuilder.Entity<TblSysActiveUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_ActiveUsers");

            entity.Property(e => e.LoginDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<TblSysBulletinLog>(entity =>
        {
            entity.HasKey(e => e.Gkfn);

            entity.ToTable("tblSYS_BulletinLog");

            entity.Property(e => e.Gkfn).HasColumnName("gkfn");
            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UrlReferrer)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSysCalendar>(entity =>
        {
            entity.ToTable("tblSYS_Calendar");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.Message)
                .HasMaxLength(7000)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSysCalendar20>(entity =>
        {
            entity.ToTable("tblSYS_Calendar20");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("_Date");
            entity.Property(e => e.Description)
                .HasMaxLength(7000)
                .IsUnicode(false);
            entity.Property(e => e.Event)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSysControl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_Control");

            entity.Property(e => e.BusyMessage)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Cid)
                .ValueGeneratedOnAdd()
                .HasColumnName("CID");
            entity.Property(e => e.CurrentVersion)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSysLoginLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_LoginLog");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LogDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<TblSysMailList>(entity =>
        {
            entity.HasKey(e => e.Gkfn);

            entity.ToTable("tblSYS_MailList");

            entity.Property(e => e.Gkfn).HasColumnName("GKFN");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblSysRawCc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_RawCC");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Fname)
                .HasMaxLength(255)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(255)
                .HasColumnName("LName");
            entity.Property(e => e.MemberType)
                .HasMaxLength(255)
                .HasColumnName("Member Type");
            entity.Property(e => e.Officer).HasMaxLength(255);
        });

        modelBuilder.Entity<TblSysRawMember>(entity =>
        {
            entity.HasKey(e => e.MemberId)
                .HasName("aaaaatblSYS_RawMembers_PK")
                .IsClustered(false);

            entity.ToTable("tblSYS_RawMembers");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.Addr).HasMaxLength(255);
            entity.Property(e => e.Assembly).HasMaxLength(255);
            entity.Property(e => e.Bdate).HasColumnType("datetime");
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Csz)
                .HasMaxLength(255)
                .HasColumnName("CSZ");
            entity.Property(e => e.Field12).HasMaxLength(255);
            entity.Property(e => e.Field17).HasMaxLength(255);
            entity.Property(e => e.Field23).HasMaxLength(255);
            entity.Property(e => e.Field24).HasMaxLength(255);
            entity.Property(e => e.FirstDegree).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.FourthDegree).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Office).HasMaxLength(255);
            entity.Property(e => e.SecondDegree).HasMaxLength(255);
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.ThirdDegree).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.Unknown)
                .HasMaxLength(255)
                .HasColumnName("unknown");
            entity.Property(e => e.Unknown2)
                .HasMaxLength(255)
                .HasColumnName("unknown2");
        });

        modelBuilder.Entity<TblSysRawMemberFullState>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_RawMemberFULL_STATE");

            entity.Property(e => e.AssemblyNumber).HasColumnName("Assembly Number");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("Birth Date");
            entity.Property(e => e.CellPhone)
                .HasMaxLength(255)
                .HasColumnName("Cell Phone");
            entity.Property(e => e.Council).HasColumnName("council");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last Name");
            entity.Property(e => e.MemberClass)
                .HasMaxLength(255)
                .HasColumnName("Member Class");
            entity.Property(e => e.MemberType)
                .HasMaxLength(255)
                .HasColumnName("Member Type");
            entity.Property(e => e.MembershipNumber).HasColumnName("Membership Number");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("Middle Name");
            entity.Property(e => e.Nickname).HasMaxLength(255);
            entity.Property(e => e.Prefix).HasMaxLength(255);
            entity.Property(e => e.PrimaryEmail)
                .HasMaxLength(255)
                .HasColumnName("Primary Email");
            entity.Property(e => e.ResidencePhone)
                .HasMaxLength(255)
                .HasColumnName("Residence Phone");
            entity.Property(e => e.Suffix).HasMaxLength(255);
            entity.Property(e => e._1stDegreeDate)
                .HasColumnType("datetime")
                .HasColumnName("1st Degree Date");
            entity.Property(e => e._2ndDegreeDate)
                .HasColumnType("datetime")
                .HasColumnName("2nd Degree Date");
            entity.Property(e => e._3rdDegreeDate)
                .HasColumnType("datetime")
                .HasColumnName("3rd Degree Date");
            entity.Property(e => e._4thDegreeDate)
                .HasColumnType("datetime")
                .HasColumnName("4th Degree Date");
        });

        modelBuilder.Entity<TblSysRawMembers201007>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_RawMembers_201007");

            entity.Property(e => e.Addr)
                .HasMaxLength(255)
                .HasColumnName("addr");
            entity.Property(e => e.Addr2)
                .HasMaxLength(255)
                .HasColumnName("Addr 2");
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Disab).HasMaxLength(255);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Exit).HasMaxLength(255);
            entity.Property(e => e.Fname).HasMaxLength(255);
            entity.Property(e => e.Lname).HasMaxLength(255);
            entity.Property(e => e.MemberNumber).HasColumnName("Member Number");
            entity.Property(e => e.MemberType)
                .HasMaxLength(255)
                .HasColumnName("Member Type");
            entity.Property(e => e.Officer).HasMaxLength(255);
            entity.Property(e => e.ReEntry)
                .HasMaxLength(255)
                .HasColumnName("Re-entry");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Zip).HasColumnName("zip");
            entity.Property(e => e._1stDegree)
                .HasColumnType("datetime")
                .HasColumnName("1st degree");
            entity.Property(e => e._2ndDegree)
                .HasColumnType("datetime")
                .HasColumnName("2nd degree");
            entity.Property(e => e._3rdDegree)
                .HasColumnType("datetime")
                .HasColumnName("3rd degree");
            entity.Property(e => e._4thDegree)
                .HasMaxLength(255)
                .HasColumnName("4th degree");
            entity.Property(e => e._4thStatus)
                .HasMaxLength(255)
                .HasColumnName("4th status");
        });

        modelBuilder.Entity<TblSysRawMembersFromMm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_RawMembersFromMM");

            entity.Property(e => e.AssemblyNumber).HasColumnName("Assembly Number");
            entity.Property(e => e.BadEmail)
                .HasMaxLength(255)
                .HasColumnName("Bad email");
            entity.Property(e => e.BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("Birth Date");
            entity.Property(e => e.CellPhone)
                .HasMaxLength(255)
                .HasColumnName("Cell Phone");
            entity.Property(e => e.Comments).HasMaxLength(255);
            entity.Property(e => e.Council).HasColumnName("council");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last Name");
            entity.Property(e => e.MemberClass)
                .HasMaxLength(255)
                .HasColumnName("Member Class");
            entity.Property(e => e.MemberType)
                .HasMaxLength(255)
                .HasColumnName("Member Type");
            entity.Property(e => e.MembershipNumber).HasColumnName("Membership Number");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("Middle Name");
            entity.Property(e => e.Nickname).HasMaxLength(255);
            entity.Property(e => e.Prefix).HasMaxLength(255);
            entity.Property(e => e.PrimaryEmail)
                .HasMaxLength(255)
                .HasColumnName("Primary Email");
            entity.Property(e => e.ResidencePhone)
                .HasMaxLength(255)
                .HasColumnName("Residence Phone");
            entity.Property(e => e.Suffix).HasMaxLength(255);
            entity.Property(e => e._1stDegreeDate)
                .HasColumnType("datetime")
                .HasColumnName("1st Degree Date");
            entity.Property(e => e._2ndDegreeDate)
                .HasColumnType("datetime")
                .HasColumnName("2nd Degree Date");
            entity.Property(e => e._3rdDegreeDate)
                .HasColumnType("datetime")
                .HasColumnName("3rd Degree Date");
            entity.Property(e => e._4thDegreeDate)
                .HasColumnType("datetime")
                .HasColumnName("4th Degree Date");
        });

        modelBuilder.Entity<TblSysRolePerm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_RolePerms");

            entity.Property(e => e.ObjId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ObjID");
            entity.Property(e => e.RoleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RoleID");
        });

        modelBuilder.Entity<TblSysSessionState>(entity =>
        {
            entity.HasKey(e => e.Sid);

            entity.ToTable("tblSYS_SessionState");

            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.Council)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LoggedInDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Roles)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SessionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SessionID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<TblSysUserRole>(entity =>
        {
            entity.HasKey(e => e.Gkfn);

            entity.ToTable("tblSYS_UserRoles");

            entity.Property(e => e.Gkfn).HasColumnName("GKFN");
            entity.Property(e => e.MemberNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RoleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RoleID");

            entity.HasOne(d => d.Role).WithMany(p => p.TblSysUserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSYS_UserRoles_tblSYS_ValRoles");
        });

        modelBuilder.Entity<TblSysValObject>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_ValObjects");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ObjId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ObjID");
            entity.Property(e => e.TypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TypeID");
        });

        modelBuilder.Entity<TblSysValObjectType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblSYS_ValObjectTypes");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TypeId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TypeID");
        });

        modelBuilder.Entity<TblSysValRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("tblSYS_ValRoles");

            entity.Property(e => e.RoleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RoleID");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Msrtype).HasColumnName("MSRType");

            entity.HasOne(d => d.MsrtypeNavigation).WithMany(p => p.TblSysValRoles)
                .HasForeignKey(d => d.Msrtype)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblSYS_ValRoles_tblRPT_ValMSRType");
        });

        modelBuilder.Entity<TblTmpEmailBounce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblTMP_EmailBounces");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Error).HasColumnName("error");
            entity.Property(e => e.Remove).HasMaxLength(255);
        });

        modelBuilder.Entity<TblTrxMpd>(entity =>
        {
            entity.HasKey(e => e.MemberId);

            entity.ToTable("tbl_TrxMPD");

            entity.Property(e => e.MemberId)
                .ValueGeneratedNever()
                .HasColumnName("MemberID");
            entity.Property(e => e.CNumber).HasColumnName("C_NUMBER");
            entity.Property(e => e.CheckDate)
                .HasColumnType("datetime")
                .HasColumnName("CHECK_DATE");
            entity.Property(e => e.CheckNo).HasColumnName("CHECK_NO");
            entity.Property(e => e.Code).HasColumnName("CODE");
            entity.Property(e => e.DupString).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Groups).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Office).HasMaxLength(50);
            entity.Property(e => e.PaidMpd)
                .HasDefaultValue(false)
                .HasColumnName("PaidMPD");
            entity.Property(e => e.Totaldue).HasColumnName("TOTALDUE");
        });

        modelBuilder.Entity<TblTrxMpdarchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_TrxMPDArchive");

            entity.Property(e => e.BatchId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BatchID");
            entity.Property(e => e.CNumber).HasColumnName("C_NUMBER");
            entity.Property(e => e.CheckDate)
                .HasColumnType("datetime")
                .HasColumnName("CHECK_DATE");
            entity.Property(e => e.CheckNo).HasColumnName("CHECK_NO");
            entity.Property(e => e.Code).HasColumnName("CODE");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("FULLNAME");
            entity.Property(e => e.Groups).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.Office).HasMaxLength(50);
            entity.Property(e => e.Totaldue).HasColumnName("TOTALDUE");
        });

        modelBuilder.Entity<TblUiControl>(entity =>
        {
            entity.HasKey(e => e.Gkfn);

            entity.ToTable("tblUI_Control");

            entity.Property(e => e.Gkfn).HasColumnName("GKFN");
            entity.Property(e => e.LastDirUpdatePrint).HasColumnType("datetime");
            entity.Property(e => e.StopAppMessage)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblValAssy>(entity =>
        {
            entity.HasKey(e => e.ANumber)
                .HasName("aaaaatbl_ValAssys_PK")
                .IsClustered(false);

            entity.ToTable("tbl_ValAssys");

            entity.Property(e => e.ANumber)
                .ValueGeneratedNever()
                .HasColumnName("A_NUMBER");
            entity.Property(e => e.ALocation)
                .HasMaxLength(50)
                .HasColumnName("A_LOCATION");
            entity.Property(e => e.AName)
                .HasMaxLength(50)
                .HasColumnName("A_NAME");
            entity.Property(e => e.AddInfo1)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 1");
            entity.Property(e => e.AddInfo2)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 2");
            entity.Property(e => e.AddInfo3)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 3");
            entity.Property(e => e.MasterLoc)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasColumnName("WebSiteURL");
        });

        modelBuilder.Entity<TblValCircle>(entity =>
        {
            entity.HasKey(e => e.CNumber)
                .HasName("aaaaatbl_ValCircles_PK")
                .IsClustered(false);

            entity.ToTable("tbl_ValCircles");

            entity.Property(e => e.CNumber)
                .ValueGeneratedNever()
                .HasColumnName("C_NUMBER");
            entity.Property(e => e.AddInfo1)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 1");
            entity.Property(e => e.AddInfo2)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 2");
            entity.Property(e => e.AddInfo3)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 3");
            entity.Property(e => e.CLocation)
                .HasMaxLength(50)
                .HasColumnName("C_LOCATION");
            entity.Property(e => e.CName)
                .HasMaxLength(50)
                .HasColumnName("C_NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TblValCouncil>(entity =>
        {
            entity.HasKey(e => e.CNumber)
                .HasName("aaaaatbl_ValCouncils_PK")
                .IsClustered(false);

            entity.ToTable("tbl_ValCouncils");

            entity.Property(e => e.CNumber)
                .ValueGeneratedNever()
                .HasColumnName("C_NUMBER");
            entity.Property(e => e.AddInfo1)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 1");
            entity.Property(e => e.AddInfo2)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 2");
            entity.Property(e => e.AddInfo3)
                .HasMaxLength(50)
                .HasColumnName("ADD INFO 3");
            entity.Property(e => e.Arbalance)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("ARBalance");
            entity.Property(e => e.BulletinUrl).HasColumnName("BulletinURL");
            entity.Property(e => e.CLocation)
                .HasMaxLength(50)
                .HasColumnName("C_LOCATION");
            entity.Property(e => e.CName)
                .HasMaxLength(32)
                .HasColumnName("C_NAME");
            entity.Property(e => e.Chartered).HasColumnType("datetime");
            entity.Property(e => e.DioceseId)
                .HasMaxLength(3)
                .HasColumnName("DioceseID");
            entity.Property(e => e.District).HasColumnName("DISTRICT");
            entity.Property(e => e.LiabIns).HasDefaultValue(false);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValue("A")
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasColumnName("WebSiteURL");

            entity.HasOne(d => d.DistrictNavigation).WithMany(p => p.TblValCouncils)
                .HasForeignKey(d => d.District)
                .HasConstraintName("FK_tbl_ValCouncils_tbl_ValDistricts");
        });

        modelBuilder.Entity<TblValDiocese>(entity =>
        {
            entity.HasKey(e => e.DioceseId)
                .HasName("aaaaatbl_ValDiocese_PK")
                .IsClustered(false);

            entity.ToTable("tbl_ValDiocese");

            entity.Property(e => e.DioceseId)
                .HasMaxLength(3)
                .HasColumnName("DioceseID");
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<TblValDistrict>(entity =>
        {
            entity.HasKey(e => e.District)
                .HasName("aaaaatbl_ValDistricts_PK")
                .IsClustered(false);

            entity.ToTable("tbl_ValDistricts");

            entity.Property(e => e.District)
                .ValueGeneratedNever()
                .HasColumnName("DISTRICT");
            entity.Property(e => e.AddInfo1)
                .HasMaxLength(255)
                .HasColumnName("ADD INFO 1");
            entity.Property(e => e.AddInfo2)
                .HasMaxLength(255)
                .HasColumnName("ADD INFO 2");
            entity.Property(e => e.DdId).HasColumnName("DD ID");
            entity.Property(e => e.Description)
                .HasMaxLength(25)
                .HasColumnName("DESCRIPTION");
        });

        modelBuilder.Entity<TblValGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId)
                .HasName("aaaaatbl_ValGroups_PK")
                .IsClustered(false);

            entity.ToTable("tbl_ValGroups", tb =>
                {
                    tb.HasTrigger("T_tbl_ValGroups_DTrig");
                    tb.HasTrigger("T_tbl_ValGroups_UTrig");
                });

            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblValOffice>(entity =>
        {
            entity.HasKey(e => e.OfficeId)
                .HasName("aaaaatbl_ValOffices_PK")
                .IsClustered(false);

            entity.ToTable("tbl_ValOffices", tb =>
                {
                    tb.HasTrigger("T_tbl_ValOffices_DTrig");
                    tb.HasTrigger("T_tbl_ValOffices_UTrig");
                });

            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.AltDescription).HasMaxLength(75);
            entity.Property(e => e.EmailAlias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OfficeDescription).HasMaxLength(75);
            entity.Property(e => e.UseAsFormalTitle).HasDefaultValue(false);
        });

        modelBuilder.Entity<TblValRptPeriod>(entity =>
        {
            entity.HasKey(e => e.RptPeriod);

            entity.ToTable("tbl_ValRptPeriods");

            entity.Property(e => e.RptPeriod).ValueGeneratedNever();
            entity.Property(e => e.DateDue).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gkfn)
                .ValueGeneratedOnAdd()
                .HasColumnName("GKFN");
        });

        modelBuilder.Entity<TblValState>(entity =>
        {
            entity.HasKey(e => e.StateCode)
                .HasName("aaaaatbl_ValStates_PK")
                .IsClustered(false);

            entity.ToTable("tbl_ValStates");

            entity.Property(e => e.StateCode).HasMaxLength(2);
            entity.Property(e => e.Gkfn)
                .ValueGeneratedOnAdd()
                .HasColumnName("GKFN");
            entity.Property(e => e.StateName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblWebSelfPublish>(entity =>
        {
            entity.HasKey(e => e.Url).HasName("PK_tblWEB_SelfPublish_1");

            entity.ToTable("tblWEB_SelfPublish");

            entity.Property(e => e.Url)
                .HasMaxLength(400)
                .HasColumnName("URL");
            entity.Property(e => e.Data).HasColumnType("text");
        });

        modelBuilder.Entity<TblWscCorMemberOffice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblWSC_CorMemberOffice");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblWSC_CorMemberOffice_tblWSC_MasMembers");

            entity.HasOne(d => d.Office).WithMany()
                .HasForeignKey(d => d.OfficeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblWSC_CorMemberOffice_tblWSC_ValOffices");
        });

        modelBuilder.Entity<TblWscMasMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK_tblWSC_MasMember");

            entity.ToTable("tblWSC_MasMembers");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.AddInfo1).HasMaxLength(100);
            entity.Property(e => e.AddInfo2).HasMaxLength(100);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AssemblyId).HasColumnName("AssemblyID");
            entity.Property(e => e.CanEditAdmUi).HasColumnName("CanEditAdmUI");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CouncilId).HasColumnName("CouncilID");
            entity.Property(e => e.Data)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FaxNumber).HasMaxLength(30);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.KofCid)
                .HasMaxLength(7)
                .HasColumnName("KofCID");
            entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Mi)
                .HasMaxLength(50)
                .HasColumnName("MI");
            entity.Property(e => e.NickName).HasMaxLength(50);
            entity.Property(e => e.PaidMpd).HasColumnName("PaidMPD");
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.Suffix).HasMaxLength(10);
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.WifesName).HasMaxLength(12);

            entity.HasOne(d => d.Assembly).WithMany(p => p.TblWscMasMembers)
                .HasForeignKey(d => d.AssemblyId)
                .HasConstraintName("FK_tblWSC_MasMembers_tblWSC_ValAssemblies");

            entity.HasOne(d => d.Council).WithMany(p => p.TblWscMasMembers)
                .HasForeignKey(d => d.CouncilId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblWSC_MasMembers_tblWSC_ValCouncils");
        });

        modelBuilder.Entity<TblWscValAssembly>(entity =>
        {
            entity.HasKey(e => e.AssemblyId);

            entity.ToTable("tblWSC_ValAssemblies");

            entity.Property(e => e.AssemblyId)
                .ValueGeneratedNever()
                .HasColumnName("AssemblyID");
            entity.Property(e => e.AddInfo1)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 1");
            entity.Property(e => e.AddInfo2)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 2");
            entity.Property(e => e.AddInfo3)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 3");
            entity.Property(e => e.AssyLocation).HasMaxLength(50);
            entity.Property(e => e.AssyName).HasMaxLength(50);
            entity.Property(e => e.MasterLoc)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasColumnName("WebSiteURL");
        });

        modelBuilder.Entity<TblWscValCouncil>(entity =>
        {
            entity.HasKey(e => e.CouncilId);

            entity.ToTable("tblWSC_ValCouncils");

            entity.Property(e => e.CouncilId)
                .ValueGeneratedNever()
                .HasColumnName("CouncilID");
            entity.Property(e => e.AddInfo1)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 1");
            entity.Property(e => e.AddInfo2)
                .HasMaxLength(60)
                .HasColumnName("ADD INFO 2");
            entity.Property(e => e.AddInfo3)
                .HasMaxLength(50)
                .HasColumnName("ADD INFO 3");
            entity.Property(e => e.Address1).HasMaxLength(50);
            entity.Property(e => e.Address2).HasMaxLength(50);
            entity.Property(e => e.Arbalance)
                .HasColumnType("numeric(14, 2)")
                .HasColumnName("ARBalance");
            entity.Property(e => e.BulletinUrl).HasColumnName("BulletinURL");
            entity.Property(e => e.Chartered).HasColumnType("datetime");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CouncilLocation).HasMaxLength(50);
            entity.Property(e => e.CouncilName).HasMaxLength(50);
            entity.Property(e => e.DioceseId)
                .HasMaxLength(3)
                .HasColumnName("DioceseID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.St).HasMaxLength(50);
            entity.Property(e => e.WebSiteUrl).HasColumnName("WebSiteURL");
            entity.Property(e => e.Zip).HasMaxLength(50);

            entity.HasOne(d => d.Diocese).WithMany(p => p.TblWscValCouncils)
                .HasForeignKey(d => d.DioceseId)
                .HasConstraintName("FK_tblWSC_ValCouncils_tblWSC_ValDiocese");

            entity.HasOne(d => d.District).WithMany(p => p.TblWscValCouncils)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK_tblWSC_ValCouncils_tblWSC_ValDistricts");
        });

        modelBuilder.Entity<TblWscValDiocese>(entity =>
        {
            entity.HasKey(e => e.DioceseId);

            entity.ToTable("tblWSC_ValDiocese");

            entity.Property(e => e.DioceseId)
                .HasMaxLength(3)
                .HasColumnName("DioceseID");
            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<TblWscValDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId);

            entity.ToTable("tblWSC_ValDistricts");

            entity.Property(e => e.DistrictId)
                .ValueGeneratedNever()
                .HasColumnName("DistrictID");
            entity.Property(e => e.AddInfo1)
                .HasMaxLength(255)
                .HasColumnName("ADD INFO 1");
            entity.Property(e => e.AddInfo2)
                .HasMaxLength(255)
                .HasColumnName("ADD INFO 2");
            entity.Property(e => e.DdId).HasColumnName("DD ID");
            entity.Property(e => e.Description)
                .HasMaxLength(25)
                .HasColumnName("DESCRIPTION");
        });

        modelBuilder.Entity<TblWscValGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.ToTable("tblWSC_ValGroups");

            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblWscValOffice>(entity =>
        {
            entity.HasKey(e => e.OfficeId);

            entity.ToTable("tblWSC_ValOffices");

            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
            entity.Property(e => e.AltDescription).HasMaxLength(50);
            entity.Property(e => e.EmailAlias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.OfficeDescription).HasMaxLength(75);

            entity.HasOne(d => d.Group).WithMany(p => p.TblWscValOffices)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK_tblWSC_ValOffices_tblWSC_ValGroups");
        });

        modelBuilder.Entity<Tim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_TIM");

            entity.Property(e => e.AccountName)
                .HasMaxLength(255)
                .HasColumnName("Account Name");
            entity.Property(e => e.Category).HasMaxLength(255);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.OriginalDescription)
                .HasMaxLength(255)
                .HasColumnName("Original Description");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(255)
                .HasColumnName("Transaction Type");
        });

        modelBuilder.Entity<TmpMileage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tmpMileage");

            entity.Property(e => e.Bellevue).HasColumnName("BELLEVUE");
            entity.Property(e => e.Bellingham).HasColumnName("BELLINGHAM");
            entity.Property(e => e.Bremerton).HasColumnName("BREMERTON");
            entity.Property(e => e.CNumber).HasColumnName("C_Number");
            entity.Property(e => e.Everett).HasColumnName("EVERETT");
            entity.Property(e => e.Kennewick).HasColumnName("KENNEWICK");
            entity.Property(e => e.Lynnwood).HasColumnName("LYNNWOOD");
            entity.Property(e => e.Moseslake).HasColumnName("MOSESLAKE");
            entity.Property(e => e.Olympia).HasColumnName("OLYMPIA");
            entity.Property(e => e.Pasco).HasColumnName("PASCO");
            entity.Property(e => e.Richland).HasColumnName("RICHLAND");
            entity.Property(e => e.Seattle).HasColumnName("SEATTLE");
            entity.Property(e => e.Spokane).HasColumnName("SPOKANE");
            entity.Property(e => e.Tacoma).HasColumnName("TACOMA");
            entity.Property(e => e.Tukwila).HasColumnName("TUKWILA");
            entity.Property(e => e.Vancouver).HasColumnName("VANCOUVER");
            entity.Property(e => e.Wenatchee).HasColumnName("WENATCHEE");
            entity.Property(e => e.Yakima).HasColumnName("YAKIMA");
        });

        modelBuilder.Entity<VewSysCc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_CCs");

            entity.Property(e => e.Cc)
                .HasMaxLength(101)
                .HasColumnName("CC");
            entity.Property(e => e.Ccemail)
                .HasMaxLength(57)
                .HasColumnName("CCEmail");
            entity.Property(e => e.Ccid).HasColumnName("CCID");
            entity.Property(e => e.CcupdatedForNewFratYear).HasColumnName("CCUpdatedForNewFratYear");
            entity.Property(e => e.Ccurl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CCURL");
        });

        modelBuilder.Entity<VewSysChaplain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_Chaplains");

            entity.Property(e => e.Chaplain).HasMaxLength(152);
            entity.Property(e => e.ChaplainEmail).HasMaxLength(57);
            entity.Property(e => e.ChaplainId).HasColumnName("ChaplainID");
            entity.Property(e => e.ChaplainUrl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ChaplainURL");
        });

        modelBuilder.Entity<VewSysCorrMemberGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_CorrMemberGroup");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
        });

        modelBuilder.Entity<VewSysCorrMemberOffice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_CorrMemberOffice");

            entity.Property(e => e.OfficeId).HasColumnName("OfficeID");
        });

        modelBuilder.Entity<VewSysCouncil>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_Councils");

            entity.Property(e => e.BulletinUrl).HasColumnName("BulletinURL");
            entity.Property(e => e.Chartered)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CouncilName).HasMaxLength(32);
            entity.Property(e => e.CouncilUrl).HasColumnName("CouncilURL");
            entity.Property(e => e.CouncilUrlg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CouncilURLG");
            entity.Property(e => e.DioceseId)
                .HasMaxLength(3)
                .HasColumnName("DioceseID");
            entity.Property(e => e.Info).HasMaxLength(176);
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .IsFixedLength();
            entity.Property(e => e.WebSiteUrl).HasColumnName("WebSiteURL");
        });

        modelBuilder.Entity<VewSysFc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_FCs");

            entity.Property(e => e.Fc)
                .HasMaxLength(101)
                .HasColumnName("FC");
            entity.Property(e => e.Fcemail)
                .HasMaxLength(57)
                .HasColumnName("FCEmail");
            entity.Property(e => e.Fcid).HasColumnName("FCID");
            entity.Property(e => e.FcupdatedForNewFratYear).HasColumnName("FCUpdatedForNewFratYear");
            entity.Property(e => e.Fcurl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FCURL");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<VewSysFf>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_FFs");

            entity.Property(e => e.Ff)
                .HasMaxLength(152)
                .HasColumnName("FF");
            entity.Property(e => e.Ffemail)
                .HasMaxLength(57)
                .HasColumnName("FFEmail");
            entity.Property(e => e.Ffid).HasColumnName("FFID");
            entity.Property(e => e.FfupdatedForNewFratYear).HasColumnName("FFUpdatedForNewFratYear");
            entity.Property(e => e.Ffurl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FFURL");
        });

        modelBuilder.Entity<VewSysFn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_FNs");

            entity.Property(e => e.Fn)
                .HasMaxLength(101)
                .HasColumnName("FN");
            entity.Property(e => e.Fnemail)
                .HasMaxLength(57)
                .HasColumnName("FNEmail");
            entity.Property(e => e.Fnid).HasColumnName("FNID");
            entity.Property(e => e.FnupdatedForNewFratYear).HasColumnName("FNUpdatedForNewFratYear");
            entity.Property(e => e.Fnurl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FNURL");
        });

        modelBuilder.Entity<VewSysFss>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_FSs");

            entity.Property(e => e.FinSec).HasMaxLength(101);
            entity.Property(e => e.FinSecId).HasColumnName("FinSecID");
            entity.Property(e => e.Fsemail)
                .HasMaxLength(57)
                .HasColumnName("FSEmail");
            entity.Property(e => e.FsupdatedForNewFratYear).HasColumnName("FSUpdatedForNewFratYear");
            entity.Property(e => e.Fsurl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FSURL");
        });

        modelBuilder.Entity<VewSysGk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vewSYS_GKs");

            entity.Property(e => e.Gkemail)
                .HasMaxLength(57)
                .HasColumnName("GKEmail");
            entity.Property(e => e.GkupdatedForNewFratYear).HasColumnName("GKUpdatedForNewFratYear");
            entity.Property(e => e.Gkurl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GKURL");
            entity.Property(e => e.GrandKnight).HasMaxLength(101);
            entity.Property(e => e.GrandKnightId).HasColumnName("GrandKnightID");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAspnetApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Applications");

            entity.Property(e => e.ApplicationName).HasMaxLength(256);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_MembershipUsers");

            entity.Property(e => e.Comment).HasColumnType("ntext");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");
            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredEmail).HasMaxLength(256);
            entity.Property(e => e.MobileAlias).HasMaxLength(16);
            entity.Property(e => e.MobilePin)
                .HasMaxLength(16)
                .HasColumnName("MobilePIN");
            entity.Property(e => e.PasswordAnswer).HasMaxLength(128);
            entity.Property(e => e.PasswordQuestion).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Profiles");

            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAspnetRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Roles");

            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.LoweredRoleName).HasMaxLength(256);
            entity.Property(e => e.RoleName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_Users");

            entity.Property(e => e.LastActivityDate).HasColumnType("datetime");
            entity.Property(e => e.LoweredUserName).HasMaxLength(256);
            entity.Property(e => e.MobileAlias).HasMaxLength(16);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_UsersInRoles");
        });

        modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_Paths");

            entity.Property(e => e.LoweredPath).HasMaxLength(256);
            entity.Property(e => e.Path).HasMaxLength(256);
        });

        modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_Shared");

            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_aspnet_WebPartState_User");

            entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
