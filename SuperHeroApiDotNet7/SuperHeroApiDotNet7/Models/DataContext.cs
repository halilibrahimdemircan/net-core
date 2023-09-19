using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SuperHeroApiDotNet7.Models;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AuthGroup> AuthGroup { get; set; }

    public virtual DbSet<AuthGroupPermissions> AuthGroupPermissions { get; set; }

    public virtual DbSet<AuthPermission> AuthPermission { get; set; }

    public virtual DbSet<AuthUser> AuthUser { get; set; }

    public virtual DbSet<AuthUserGroups> AuthUserGroups { get; set; }

    public virtual DbSet<AuthUserUserPermissions> AuthUserUserPermissions { get; set; }

    public virtual DbSet<CemDeneme> CemDeneme { get; set; }

    public virtual DbSet<CemDeneme1> CemDeneme1 { get; set; }

    public virtual DbSet<CemDeneme4> CemDeneme4 { get; set; }

    public virtual DbSet<CraftCraft> CraftCraft { get; set; }

    public virtual DbSet<CraftVwCraftItems> CraftVwCraftItems { get; set; }

    public virtual DbSet<CreatureLevelGecici> CreatureLevelGecici { get; set; }

    public virtual DbSet<DjangoAdminLog> DjangoAdminLog { get; set; }

    public virtual DbSet<DjangoContentType> DjangoContentType { get; set; }

    public virtual DbSet<DjangoMigrations> DjangoMigrations { get; set; }

    public virtual DbSet<DjangoSession> DjangoSession { get; set; }

    public virtual DbSet<GameBattle> GameBattle { get; set; }

    public virtual DbSet<GameBattleLog> GameBattleLog { get; set; }

    public virtual DbSet<GameBodyItemType> GameBodyItemType { get; set; }

    public virtual DbSet<GameBodyStat> GameBodyStat { get; set; }

    public virtual DbSet<GameCharacterBodyItems> GameCharacterBodyItems { get; set; }

    public virtual DbSet<GameCharacterInventory> GameCharacterInventory { get; set; }

    public virtual DbSet<GameCharacterItems> GameCharacterItems { get; set; }

    public virtual DbSet<GameCharacterSkillAndStat> GameCharacterSkillAndStat { get; set; }

    public virtual DbSet<GameCharacters> GameCharacters { get; set; }

    public virtual DbSet<GameCharactersStyle> GameCharactersStyle { get; set; }

    public virtual DbSet<GameCharactersStyles> GameCharactersStyles { get; set; }

    public virtual DbSet<GameCreatureClasslevelstats> GameCreatureClasslevelstats { get; set; }

    public virtual DbSet<GameCreatureLoot> GameCreatureLoot { get; set; }

    public virtual DbSet<GameCreatures> GameCreatures { get; set; }

    public virtual DbSet<GameDungeons> GameDungeons { get; set; }

    public virtual DbSet<GameFarm> GameFarm { get; set; }

    public virtual DbSet<GameFarmLog> GameFarmLog { get; set; }

    public virtual DbSet<GameItems> GameItems { get; set; }

    public virtual DbSet<GameSkillAndStat> GameSkillAndStat { get; set; }

    public virtual DbSet<GameSpell> GameSpell { get; set; }

    public virtual DbSet<GameStyles> GameStyles { get; set; }

    public virtual DbSet<GameUserSpells> GameUserSpells { get; set; }

    public virtual DbSet<GameUserTokens> GameUserTokens { get; set; }

    public virtual DbSet<GameUsers> GameUsers { get; set; }

    public virtual DbSet<GameUsersCopy1> GameUsersCopy1 { get; set; }

    public virtual DbSet<GameVwCharacterItemsWithInfo> GameVwCharacterItemsWithInfo { get; set; }

    public virtual DbSet<GameVwCharacterSkillAndSpell> GameVwCharacterSkillAndSpell { get; set; }

    public virtual DbSet<GameVwCharacterSkills> GameVwCharacterSkills { get; set; }

    public virtual DbSet<GameVwCharacterStyles> GameVwCharacterStyles { get; set; }

    public virtual DbSet<GameWeaponSkillRelation> GameWeaponSkillRelation { get; set; }

    public virtual DbSet<ItemGecici> ItemGecici { get; set; }

    public virtual DbSet<ItemStatsGecici> ItemStatsGecici { get; set; }

    public virtual DbSet<Newview> Newview { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=104.247.165.244;Database=game;Username=game_admin;Password=sU8^0338zB!e;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_pkey");

            entity.ToTable("auth_group");

            entity.HasIndex(e => e.Name, "auth_group_name_a6ea08ec_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Name, "auth_group_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .HasColumnName("name");
        });

        modelBuilder.Entity<AuthGroupPermissions>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_permissions_pkey");

            entity.ToTable("auth_group_permissions");

            entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9");

            entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq").IsUnique();

            entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
        });

        modelBuilder.Entity<AuthPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_permission_pkey");

            entity.ToTable("auth_permission");

            entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b");

            entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codename)
                .HasMaxLength(100)
                .HasColumnName("codename");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");

            entity.HasOne(d => d.ContentType).WithMany(p => p.AuthPermission)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
        });

        modelBuilder.Entity<AuthUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_pkey");

            entity.ToTable("auth_user");

            entity.HasIndex(e => e.Username, "auth_user_username_6821ab7c_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.HasIndex(e => e.Username, "auth_user_username_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateJoined).HasColumnName("date_joined");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(150)
                .HasColumnName("first_name");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.IsStaff).HasColumnName("is_staff");
            entity.Property(e => e.IsSuperuser).HasColumnName("is_superuser");
            entity.Property(e => e.LastLogin).HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AuthUserGroups>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_groups_pkey");

            entity.ToTable("auth_user_groups");

            entity.HasIndex(e => e.GroupId, "auth_user_groups_group_id_97559544");

            entity.HasIndex(e => e.UserId, "auth_user_groups_user_id_6a12ed8b");

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "auth_user_groups_user_id_group_id_94350c0c_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_group_id_97559544_fk_auth_group_id");

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserGroups)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_groups_user_id_6a12ed8b_fk_auth_user_id");
        });

        modelBuilder.Entity<AuthUserUserPermissions>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_user_user_permissions_pkey");

            entity.ToTable("auth_user_user_permissions");

            entity.HasIndex(e => e.PermissionId, "auth_user_user_permissions_permission_id_1fbb5f2c");

            entity.HasIndex(e => e.UserId, "auth_user_user_permissions_user_id_a95ead1b");

            entity.HasIndex(e => new { e.UserId, e.PermissionId }, "auth_user_user_permissions_user_id_permission_id_14a6b632_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PermissionId).HasColumnName("permission_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permi_permission_id_1fbb5f2c_fk_auth_perm");

            entity.HasOne(d => d.User).WithMany(p => p.AuthUserUserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_user_user_permissions_user_id_a95ead1b_fk_auth_user_id");
        });

        modelBuilder.Entity<CemDeneme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cem_deneme");

            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
        });

        modelBuilder.Entity<CemDeneme1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cem_deneme_1");

            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
        });

        modelBuilder.Entity<CemDeneme4>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cem_deneme_4");

            entity.Property(e => e.CemDeneme3)
                .HasColumnType("character varying")
                .HasColumnName("cem_deneme_3");
        });

        modelBuilder.Entity<CraftCraft>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("craft_craft");

            entity.Property(e => e.CraftId).HasColumnName("craft_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.OutputCount)
                .HasDefaultValueSql("1")
                .HasColumnName("output_count");
            entity.Property(e => e.RequiredItemId).HasColumnName("required_item_id");
            entity.Property(e => e.RequiredQuantity).HasColumnName("required_quantity");
        });

        modelBuilder.Entity<CraftVwCraftItems>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("craft_vw_craft_items");

            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemName)
                .HasColumnType("character varying")
                .HasColumnName("item_name");
            entity.Property(e => e.RequiredItems).HasColumnName("required_items");
            entity.Property(e => e.RequiredLevel).HasColumnName("required_level");
        });

        modelBuilder.Entity<CreatureLevelGecici>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("creature_level_gecici");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.UnitClass).HasColumnName("unit_class");
        });

        modelBuilder.Entity<DjangoAdminLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_admin_log_pkey");

            entity.ToTable("django_admin_log");

            entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb");

            entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionFlag).HasColumnName("action_flag");
            entity.Property(e => e.ActionTime).HasColumnName("action_time");
            entity.Property(e => e.ChangeMessage).HasColumnName("change_message");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.ObjectRepr)
                .HasMaxLength(200)
                .HasColumnName("object_repr");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.DjangoAdminLog)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

            entity.HasOne(d => d.User).WithMany(p => p.DjangoAdminLog)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_admin_log_user_id_c564eba6_fk_auth_user_id");
        });

        modelBuilder.Entity<DjangoContentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_content_type_pkey");

            entity.ToTable("django_content_type");

            entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type_app_label_model_76bd3d3b_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppLabel)
                .HasMaxLength(100)
                .HasColumnName("app_label");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
        });

        modelBuilder.Entity<DjangoMigrations>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_migrations_pkey");

            entity.ToTable("django_migrations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.App)
                .HasMaxLength(255)
                .HasColumnName("app");
            entity.Property(e => e.Applied).HasColumnName("applied");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DjangoSession>(entity =>
        {
            entity.HasKey(e => e.SessionKey).HasName("django_session_pkey");

            entity.ToTable("django_session");

            entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663");

            entity.HasIndex(e => e.SessionKey, "django_session_session_key_c0390e0f_like").HasOperators(new[] { "varchar_pattern_ops" });

            entity.Property(e => e.SessionKey)
                .HasMaxLength(40)
                .HasColumnName("session_key");
            entity.Property(e => e.ExpireDate).HasColumnName("expire_date");
            entity.Property(e => e.SessionData).HasColumnName("session_data");
        });

        modelBuilder.Entity<GameBattle>(entity =>
        {
            entity.HasKey(e => e.BattleId).HasName("game_battle_pkey");

            entity.ToTable("game_battle");

            entity.Property(e => e.BattleId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("battle_id");
            entity.Property(e => e.CharacterHp).HasColumnName("character_hp");
            entity.Property(e => e.CharacterHpAvailable).HasColumnName("character_hp_available");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.CreatureHp).HasColumnName("creature_hp");
            entity.Property(e => e.CreatureHpAvailable).HasColumnName("creature_hp_available");
            entity.Property(e => e.CreatureId)
                .HasColumnType("character varying")
                .HasColumnName("creature_id");
            entity.Property(e => e.InsertDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("insert_date");
            entity.Property(e => e.IsCharacterWin).HasColumnName("is_character_win");
            entity.Property(e => e.IsFinish).HasColumnName("is_finish");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("update_date");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<GameBattleLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("game_battle_log_pkey");

            entity.ToTable("game_battle_log");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.BattleId).HasColumnName("battle_id");
            entity.Property(e => e.CharacterHp).HasColumnName("character_hp");
            entity.Property(e => e.CharacterSkillName)
                .HasColumnType("character varying")
                .HasColumnName("character_skill_name");
            entity.Property(e => e.CharacterSpellId).HasColumnName("character_spell_id");
            entity.Property(e => e.CharacterSpellName)
                .HasColumnType("character varying")
                .HasColumnName("character_spell_name");
            entity.Property(e => e.CreatureHp)
                .HasColumnType("character varying")
                .HasColumnName("creature_hp");
            entity.Property(e => e.Damage).HasColumnName("damage");
            entity.Property(e => e.Description)
                .HasColumnType("json")
                .HasColumnName("description");
            entity.Property(e => e.InsertDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("insert_date");
            entity.Property(e => e.IsCharacterAttack).HasColumnName("is_character_attack");
            entity.Property(e => e.StatsDescriptionList)
                .HasColumnType("json")
                .HasColumnName("stats_description_list");
        });

        modelBuilder.Entity<GameBodyItemType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_body_item_type");

            entity.Property(e => e.AcceptType)
                .HasColumnType("jsonb")
                .HasColumnName("accept_type");
            entity.Property(e => e.BodySlot).HasColumnName("body_slot");
            entity.Property(e => e.ItemClass)
                .HasColumnType("character varying")
                .HasColumnName("item_class");
            entity.Property(e => e.ItemType)
                .HasColumnType("character varying")
                .HasColumnName("item_type");
        });

        modelBuilder.Entity<GameBodyStat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_body_stat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatId).HasColumnName("stat_id");
            entity.Property(e => e.StatName)
                .HasColumnType("character varying")
                .HasColumnName("stat_name");
        });

        modelBuilder.Entity<GameCharacterBodyItems>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_character_body_items");

            entity.Property(e => e.Additional)
                .HasColumnType("jsonb")
                .HasColumnName("additional");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Durability).HasColumnName("durability");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<GameCharacterInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_character_inventory");

            entity.Property(e => e.Additional)
                .HasColumnType("jsonb")
                .HasColumnName("additional");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.Durability).HasColumnName("durability");
            entity.Property(e => e.Enchant)
                .HasColumnType("character varying")
                .HasColumnName("enchant");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId)
                .HasColumnType("character varying")
                .HasColumnName("item_id");
            entity.Property(e => e.ItemName)
                .HasColumnType("character varying")
                .HasColumnName("item_name");
            entity.Property(e => e.MaxDurability).HasColumnName("max_durability");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<GameCharacterItems>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("game_character_items_pkey");

            entity.ToTable("game_character_items");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Additional)
                .HasColumnType("jsonb")
                .HasColumnName("additional");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Durability).HasColumnName("durability");
            entity.Property(e => e.IsBody).HasColumnName("is_body");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("false")
                .HasColumnName("is_deleted");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<GameCharacterSkillAndStat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("game_character_skill_and_stat_pkey");

            entity.ToTable("game_character_skill_and_stat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(6)
                .HasColumnName("created_at");
            entity.Property(e => e.Point).HasColumnName("point");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.UpdatedAt)
                .HasPrecision(6)
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<GameCharacters>(entity =>
        {
            entity.HasKey(e => e.CharacterId).HasName("characters_pkey");

            entity.ToTable("game_characters");

            entity.Property(e => e.CharacterId)
                .HasDefaultValueSql("nextval('characters_character_id_seq'::regclass)")
                .HasColumnName("character_id");
            entity.Property(e => e.CharacterName)
                .HasMaxLength(100)
                .HasColumnName("character_name");
            entity.Property(e => e.GoldAmount).HasColumnName("gold_amount");
            entity.Property(e => e.HealthPointsAvailable).HasColumnName("health_points_available");
            entity.Property(e => e.HealthPointsMax).HasColumnName("health_points_max");
            entity.Property(e => e.ImageName)
                .HasColumnType("character varying")
                .HasColumnName("image_name");
            entity.Property(e => e.ImageUrl)
                .HasColumnType("character varying")
                .HasColumnName("image_url");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<GameCharactersStyle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_characters_style");

            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.FacialHairColor)
                .HasColumnType("character varying")
                .HasColumnName("facial_hair_color");
            entity.Property(e => e.FacialHairStyle)
                .HasColumnType("character varying")
                .HasColumnName("facial_hair_style");
            entity.Property(e => e.HairColor)
                .HasColumnType("character varying")
                .HasColumnName("hair_color");
            entity.Property(e => e.HairStyle)
                .HasColumnType("character varying")
                .HasColumnName("hair_style");
            entity.Property(e => e.IsMale).HasColumnName("is_male");
            entity.Property(e => e.PantsColor)
                .HasColumnType("character varying")
                .HasColumnName("pants_color");
            entity.Property(e => e.ShirtColor)
                .HasColumnType("character varying")
                .HasColumnName("shirt_color");
            entity.Property(e => e.SkinTone)
                .HasColumnType("character varying")
                .HasColumnName("skin_tone");
        });

        modelBuilder.Entity<GameCharactersStyles>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_characters_styles");

            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.StyleId).HasColumnName("style_id");
            entity.Property(e => e.StyleValue)
                .HasColumnType("character varying")
                .HasColumnName("style_value");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GameCreatureClasslevelstats>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_creature_classlevelstats");

            entity.Property(e => e.Attackpower).HasColumnName("attackpower");
            entity.Property(e => e.Basearmor).HasColumnName("basearmor");
            entity.Property(e => e.Basehp0).HasColumnName("basehp0");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Rangedattackpower).HasColumnName("rangedattackpower");
        });

        modelBuilder.Entity<GameCreatureLoot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_creature_loot");

            entity.Property(e => e.Chance).HasColumnName("chance");
            entity.Property(e => e.CreatureId).HasColumnName("creature_id");
            entity.Property(e => e.CreatureName)
                .HasColumnType("character varying")
                .HasColumnName("creature_name");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.MaxCount).HasColumnName("max_count");
            entity.Property(e => e.MinCount).HasColumnName("min_count");
        });

        modelBuilder.Entity<GameCreatures>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_creatures");

            entity.Property(e => e.AttackPower).HasColumnName("attack_power");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.CreatureId).HasColumnName("creature_id");
            entity.Property(e => e.HealthPoints).HasColumnName("health_points");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImageUrl)
                .HasColumnType("character varying")
                .HasColumnName("image_url");
            entity.Property(e => e.IsQuest).HasColumnName("is_quest");
            entity.Property(e => e.MaxGold).HasColumnName("max_gold");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity.Property(e => e.MinGold).HasColumnName("min_gold");
            entity.Property(e => e.MinLevel).HasColumnName("min_level");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.SubName)
                .HasColumnType("character varying")
                .HasColumnName("sub_name");
        });

        modelBuilder.Entity<GameDungeons>(entity =>
        {
            entity.HasKey(e => e.DungeonId).HasName("game_dungeons_pkey");

            entity.ToTable("game_dungeons");

            entity.Property(e => e.DungeonId).HasColumnName("dungeon_id");
            entity.Property(e => e.DungeonName)
                .HasMaxLength(100)
                .HasColumnName("dungeon_name");
            entity.Property(e => e.RequiredLevel).HasColumnName("required_level");
        });

        modelBuilder.Entity<GameFarm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_farm");

            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.CreatureId).HasColumnName("creature_id");
            entity.Property(e => e.FarmId)
                .HasDefaultValueSql("nextval('game_farm_id_seq'::regclass)")
                .HasColumnName("farm_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<GameFarmLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("game_farm_log_pkey");

            entity.ToTable("game_farm_log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CharacterSkillName)
                .HasColumnType("character varying")
                .HasColumnName("character_skill_name");
            entity.Property(e => e.CharacterSpellId).HasColumnName("character_spell_id");
            entity.Property(e => e.CharacterSpellName)
                .HasColumnType("character varying")
                .HasColumnName("character_spell_name");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DesciriptionList)
                .HasColumnType("jsonb")
                .HasColumnName("desciription_list");
            entity.Property(e => e.FarmId).HasColumnName("farm_id");
            entity.Property(e => e.StatsDescriptionList)
                .HasColumnType("jsonb")
                .HasColumnName("stats_description_list");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<GameItems>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_items");

            entity.Property(e => e.BonusStats)
                .HasColumnType("character varying")
                .HasColumnName("bonus_stats");
            entity.Property(e => e.BuyPrice).HasColumnName("buy_price");
            entity.Property(e => e.Description)
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Equippable).HasColumnName("equippable");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InventoryType)
                .HasColumnType("character varying")
                .HasColumnName("inventory_type");
            entity.Property(e => e.InventoryTypeWow)
                .HasColumnType("character varying")
                .HasColumnName("inventory_type_wow");
            entity.Property(e => e.ItemClass)
                .HasColumnType("character varying")
                .HasColumnName("item_class");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.ItemName)
                .HasColumnType("character varying")
                .HasColumnName("item_name");
            entity.Property(e => e.ItemSubClass)
                .HasColumnType("character varying")
                .HasColumnName("item_sub_class");
            entity.Property(e => e.ItemType)
                .HasColumnType("character varying")
                .HasColumnName("item_type");
            entity.Property(e => e.MaxCount).HasColumnName("max_count");
            entity.Property(e => e.MaxDurability).HasColumnName("max_durability");
            entity.Property(e => e.Quality).HasColumnName("quality");
            entity.Property(e => e.RequiredLevel).HasColumnName("required_level");
            entity.Property(e => e.RequiredSkill)
                .HasColumnType("character varying")
                .HasColumnName("required_skill");
            entity.Property(e => e.SellPrice).HasColumnName("sell_price");
            entity.Property(e => e.Stackable).HasColumnName("stackable");
            entity.Property(e => e.Upgradable).HasColumnName("upgradable");
            entity.Property(e => e.WeaponInfo)
                .HasColumnType("character varying")
                .HasColumnName("weapon_info");
        });

        modelBuilder.Entity<GameSkillAndStat>(entity =>
        {
            entity.HasKey(e => e.SkillId).HasName("game_attributes_pkey");

            entity.ToTable("game_skill_and_stat");

            entity.Property(e => e.SkillId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("skill_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ImageName)
                .HasColumnType("character varying")
                .HasColumnName("image_name");
            entity.Property(e => e.ImageUrl)
                .HasColumnType("character varying")
                .HasColumnName("image_url");
            entity.Property(e => e.IsSkill).HasColumnName("is_skill");
            entity.Property(e => e.SkillMax).HasColumnName("skill_max");
            entity.Property(e => e.SkillMin).HasColumnName("skill_min");
            entity.Property(e => e.SkillName)
                .HasMaxLength(255)
                .HasColumnName("skill_name");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GameSpell>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_spell");

            entity.Property(e => e.CoolDownCount).HasColumnName("cool_down_count");
            entity.Property(e => e.Desciription)
                .HasColumnType("character varying")
                .HasColumnName("desciription");
            entity.Property(e => e.EffectMaxPower).HasColumnName("effect_max_power");
            entity.Property(e => e.EffectMinPower).HasColumnName("effect_min_power");
            entity.Property(e => e.EffectRoundCount).HasColumnName("effect_round_count");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImageName)
                .HasColumnType("character varying")
                .HasColumnName("image_name");
            entity.Property(e => e.ImageUrl)
                .HasColumnType("character varying")
                .HasColumnName("image_url");
            entity.Property(e => e.IsDamageSpell).HasColumnName("is_damage_spell");
            entity.Property(e => e.IsRequiredShield).HasColumnName("is_required_shield");
            entity.Property(e => e.MaxPower).HasColumnName("max_power");
            entity.Property(e => e.MinPower).HasColumnName("min_power");
            entity.Property(e => e.RequiredSkillPoint).HasColumnName("required_skill_point");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
            entity.Property(e => e.SpellName)
                .HasColumnType("character varying")
                .HasColumnName("spell_name");
        });

        modelBuilder.Entity<GameStyles>(entity =>
        {
            entity.HasKey(e => e.StyleId).HasName("game_styles_pkey");

            entity.ToTable("game_styles");

            entity.Property(e => e.StyleId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("style_id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("false")
                .HasColumnName("is_deleted");
            entity.Property(e => e.StyleTitle)
                .HasMaxLength(255)
                .HasColumnName("style_title");
            entity.Property(e => e.StyleType)
                .HasMaxLength(255)
                .HasColumnName("style_type");
            entity.Property(e => e.StyleValue)
                .HasMaxLength(255)
                .HasColumnName("style_value");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<GameUserSpells>(entity =>
        {
            entity.HasKey(e => e.UserSpellId).HasName("user_spells_pkey");

            entity.ToTable("game_user_spells");

            entity.Property(e => e.UserSpellId)
                .HasDefaultValueSql("nextval('user_spells_user_spell_id_seq'::regclass)")
                .HasColumnName("user_spell_id");
            entity.Property(e => e.Spells)
                .HasColumnType("jsonb")
                .HasColumnName("spells");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<GameUserTokens>(entity =>
        {
            entity.HasKey(e => e.TokenId).HasName("user_tokens_pkey");

            entity.ToTable("game_user_tokens");

            entity.Property(e => e.TokenId)
                .HasDefaultValueSql("nextval('user_tokens_token_id_seq'::regclass)")
                .HasColumnName("token_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.RemoteIp)
                .HasMaxLength(50)
                .HasColumnName("remote_ip");
            entity.Property(e => e.Token)
                .HasMaxLength(2048)
                .HasColumnName("token");
            entity.Property(e => e.Tokenandroid)
                .HasMaxLength(2048)
                .HasColumnName("tokenandroid");
            entity.Property(e => e.Tokenios)
                .HasMaxLength(2048)
                .HasColumnName("tokenios");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(500)
                .HasColumnName("user_agent");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<GameUsers>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("users_pkey");

            entity.ToTable("game_users");

            entity.HasIndex(e => e.Email, "users_email_key").IsUnique();

            entity.Property(e => e.UserId)
                .HasDefaultValueSql("nextval('users_user_id_seq'::regclass)")
                .HasColumnName("user_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<GameUsersCopy1>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("game_users_copy1_pkey");

            entity.ToTable("game_users_copy1");

            entity.HasIndex(e => e.Email, "game_users_copy1_email_key").IsUnique();

            entity.Property(e => e.UserId)
                .HasDefaultValueSql("nextval('users_user_id_seq'::regclass)")
                .HasColumnName("user_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp(6) without time zone")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<GameVwCharacterItemsWithInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("game_vw_character_items_with_info");

            entity.Property(e => e.Additional)
                .HasColumnType("jsonb")
                .HasColumnName("additional");
            entity.Property(e => e.BonusStats)
                .HasColumnType("character varying")
                .HasColumnName("bonus_stats");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Durability).HasColumnName("durability");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InventoryType)
                .HasColumnType("character varying")
                .HasColumnName("inventory_type");
            entity.Property(e => e.IsBody).HasColumnName("is_body");
            entity.Property(e => e.ItemClass)
                .HasColumnType("character varying")
                .HasColumnName("item_class");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.ItemLevel).HasColumnName("item_level");
            entity.Property(e => e.ItemName)
                .HasColumnType("character varying")
                .HasColumnName("item_name");
            entity.Property(e => e.ItemType)
                .HasColumnType("character varying")
                .HasColumnName("item_type");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.WeaponInfo)
                .HasColumnType("character varying")
                .HasColumnName("weapon_info");
        });

        modelBuilder.Entity<GameVwCharacterSkillAndSpell>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("game_vw_character_skill_and_spell");

            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.CoolDownCount).HasColumnName("cool_down_count");
            entity.Property(e => e.Desciription)
                .HasColumnType("character varying")
                .HasColumnName("desciription");
            entity.Property(e => e.EffectMaxPower).HasColumnName("effect_max_power");
            entity.Property(e => e.EffectMinPower).HasColumnName("effect_min_power");
            entity.Property(e => e.EffectRoundCount).HasColumnName("effect_round_count");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImageName)
                .HasColumnType("character varying")
                .HasColumnName("image_name");
            entity.Property(e => e.ImageUrl)
                .HasColumnType("character varying")
                .HasColumnName("image_url");
            entity.Property(e => e.IsDamageSpell).HasColumnName("is_damage_spell");
            entity.Property(e => e.IsRequiredShield).HasColumnName("is_required_shield");
            entity.Property(e => e.IsUsable).HasColumnName("is_usable");
            entity.Property(e => e.MaxPower).HasColumnName("max_power");
            entity.Property(e => e.MinPower).HasColumnName("min_power");
            entity.Property(e => e.Point).HasColumnName("point");
            entity.Property(e => e.RequiredSkillPoint).HasColumnName("required_skill_point");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.SkillName)
                .HasMaxLength(255)
                .HasColumnName("skill_name");
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
            entity.Property(e => e.SpellName)
                .HasColumnType("character varying")
                .HasColumnName("spell_name");
        });

        modelBuilder.Entity<GameVwCharacterSkills>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("game_vw_character_skills");

            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.IsSkill).HasColumnName("is_skill");
            entity.Property(e => e.Point).HasColumnName("point");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
            entity.Property(e => e.SkillName)
                .HasMaxLength(255)
                .HasColumnName("skill_name");
        });

        modelBuilder.Entity<GameVwCharacterStyles>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("game_vw_character_styles");

            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.StyleTitle)
                .HasMaxLength(255)
                .HasColumnName("style_title");
            entity.Property(e => e.StyleValue)
                .HasColumnType("character varying")
                .HasColumnName("style_value");
        });

        modelBuilder.Entity<GameWeaponSkillRelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("game_weapon_skill_relation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ItemType)
                .HasColumnType("character varying")
                .HasColumnName("item_type");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");
        });

        modelBuilder.Entity<ItemGecici>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("item_gecici");

            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.Stackable).HasColumnName("stackable");
        });

        modelBuilder.Entity<ItemStatsGecici>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("item_stats_gecici");

            entity.Property(e => e.BonusStat)
                .HasColumnType("character varying")
                .HasColumnName("bonus_stat");
            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.WeaponInfo)
                .HasColumnType("character varying")
                .HasColumnName("weapon_info");
        });

        modelBuilder.Entity<Newview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("newview");

            entity.Property(e => e.IntventoryType)
                .HasColumnType("character varying")
                .HasColumnName("intventory_type");
            entity.Property(e => e.ItemClass)
                .HasColumnType("character varying")
                .HasColumnName("item_class");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });
        modelBuilder.HasSequence("game_character_skill_and_stat_id_seq");
        modelBuilder.HasSequence("game_characters_styles_id_seq");
        modelBuilder.HasSequence("game_farm_id_seq");
        modelBuilder.HasSequence("game_farm_log_id_seq");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
