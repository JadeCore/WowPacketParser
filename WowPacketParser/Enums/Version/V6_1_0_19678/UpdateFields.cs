namespace WowPacketParser.Enums.Version.V6_1_0_19678
{
    // ReSharper disable InconsistentNaming
    // V6_1_0_19678
    public enum ObjectField
    {
        OBJECT_FIELD_GUID                                      = 0x000, // Size: 4, Flags: PUBLIC
        OBJECT_FIELD_DATA                                      = 0x004, // Size: 4, Flags: PUBLIC
        OBJECT_FIELD_TYPE                                      = 0x008, // Size: 1, Flags: PUBLIC
        OBJECT_FIELD_ENTRY                                     = 0x009, // Size: 1, Flags: DYNAMIC
        OBJECT_DYNAMIC_FLAGS                                   = 0x00A, // Size: 1, Flags: DYNAMIC, URGENT
        OBJECT_FIELD_SCALE_X                                   = 0x00B, // Size: 1, Flags: PUBLIC
        OBJECT_END                                             = 0x00C
    }

    public enum ObjectDynamicField
    {
        OBJECT_DYNAMIC_END                                     = 0x000,
    }

    public enum ItemField
    {
        ITEM_FIELD_OWNER                                       = ObjectField.OBJECT_END + 0x000, // Size: 4, Flags: PUBLIC
        ITEM_FIELD_CONTAINED                                   = ObjectField.OBJECT_END + 0x004, // Size: 4, Flags: PUBLIC
        ITEM_FIELD_CREATOR                                     = ObjectField.OBJECT_END + 0x008, // Size: 4, Flags: PUBLIC
        ITEM_FIELD_GIFTCREATOR                                 = ObjectField.OBJECT_END + 0x00C, // Size: 4, Flags: PUBLIC
        ITEM_FIELD_STACK_COUNT                                 = ObjectField.OBJECT_END + 0x010, // Size: 1, Flags: OWNER
        ITEM_FIELD_DURATION                                    = ObjectField.OBJECT_END + 0x011, // Size: 1, Flags: OWNER
        ITEM_FIELD_SPELL_CHARGES                               = ObjectField.OBJECT_END + 0x012, // Size: 5, Flags: OWNER
        ITEM_FIELD_FLAGS                                       = ObjectField.OBJECT_END + 0x017, // Size: 1, Flags: PUBLIC
        ITEM_FIELD_ENCHANTMENT                                 = ObjectField.OBJECT_END + 0x018, // Size: 39, Flags: PUBLIC
        ITEM_FIELD_PROPERTY_SEED                               = ObjectField.OBJECT_END + 0x03F, // Size: 1, Flags: PUBLIC
        ITEM_FIELD_RANDOM_PROPERTIES_ID                        = ObjectField.OBJECT_END + 0x040, // Size: 1, Flags: PUBLIC
        ITEM_FIELD_DURABILITY                                  = ObjectField.OBJECT_END + 0x041, // Size: 1, Flags: OWNER
        ITEM_FIELD_MAXDURABILITY                               = ObjectField.OBJECT_END + 0x042, // Size: 1, Flags: OWNER
        ITEM_FIELD_CREATE_PLAYED_TIME                          = ObjectField.OBJECT_END + 0x043, // Size: 1, Flags: PUBLIC
        ITEM_FIELD_MODIFIERS_MASK                              = ObjectField.OBJECT_END + 0x044, // Size: 1, Flags: OWNER
        ITEM_FIELD_CONTEXT                                     = ObjectField.OBJECT_END + 0x045, // Size: 1, Flags: PUBLIC
        ITEM_END                                               = ObjectField.OBJECT_END + 0x046,
    }

    public enum ItemDynamicField
    {
        ITEM_DYNAMIC_FIELD_MODIFIERS                           = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000, // Flags: OWNER
        ITEM_DYNAMIC_FIELD_BONUSLIST_IDS                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x001, // Flags: OWNER, 0x100
        ITEM_DYNAMIC_END                                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x002,
    }

    public enum ContainerField
    {
        CONTAINER_FIELD_SLOT_1                                 = ItemField.ITEM_END + 0x000, // Size: 144, Flags: PUBLIC
        CONTAINER_FIELD_NUM_SLOTS                              = ItemField.ITEM_END + 0x090, // Size: 1, Flags: PUBLIC
        CONTAINER_END                                          = ItemField.ITEM_END + 0x091,
    }

    public enum ContainerDynamicField
    {
        CONTAINER_DYNAMIC_END                                  = ItemDynamicField.ITEM_DYNAMIC_END + 0x000,
    }

    public enum UnitField
    {
        UNIT_FIELD_CHARM                                       = ObjectField.OBJECT_END + 0x000, // Size: 4, Flags: PUBLIC
        UNIT_FIELD_SUMMON                                      = ObjectField.OBJECT_END + 0x004, // Size: 4, Flags: PUBLIC
        UNIT_FIELD_CRITTER                                     = ObjectField.OBJECT_END + 0x008, // Size: 4, Flags: PRIVATE
        UNIT_FIELD_CHARMEDBY                                   = ObjectField.OBJECT_END + 0x00C, // Size: 4, Flags: PUBLIC
        UNIT_FIELD_SUMMONEDBY                                  = ObjectField.OBJECT_END + 0x010, // Size: 4, Flags: PUBLIC
        UNIT_FIELD_CREATEDBY                                   = ObjectField.OBJECT_END + 0x014, // Size: 4, Flags: PUBLIC
        UNIT_FIELD_DEMON_CREATOR                               = ObjectField.OBJECT_END + 0x018, // Size: 4, Flags: PUBLIC
        UNIT_FIELD_TARGET                                      = ObjectField.OBJECT_END + 0x01C, // Size: 4, Flags: PUBLIC
        UNIT_FIELD_BATTLE_PET_COMPANION_GUID                   = ObjectField.OBJECT_END + 0x020, // Size: 4, Flags: PUBLIC
        UNIT_FIELD_BATTLE_PET_DB_ID                            = ObjectField.OBJECT_END + 0x024, // Size: 2, Flags: PUBLIC
        UNIT_FIELD_CHANNEL_OBJECT                              = ObjectField.OBJECT_END + 0x026, // Size: 4, Flags: PUBLIC, URGENT
        UNIT_CHANNEL_SPELL                                     = ObjectField.OBJECT_END + 0x02A, // Size: 1, Flags: PUBLIC, URGENT
        UNIT_FIELD_SUMMONED_BY_HOME_REALM                      = ObjectField.OBJECT_END + 0x02B, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_BYTES_0                                     = ObjectField.OBJECT_END + 0x02C, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_DISPLAY_POWER                               = ObjectField.OBJECT_END + 0x02D, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_OVERRIDE_DISPLAY_POWER_ID                   = ObjectField.OBJECT_END + 0x02E, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_HEALTH                                      = ObjectField.OBJECT_END + 0x02F, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_POWER                                       = ObjectField.OBJECT_END + 0x030, // Size: 6, Flags: PUBLIC, URGENT_SELF_ONLY
        UNIT_FIELD_MAXHEALTH                                   = ObjectField.OBJECT_END + 0x036, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_MAXPOWER                                    = ObjectField.OBJECT_END + 0x037, // Size: 6, Flags: PUBLIC
        UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER                   = ObjectField.OBJECT_END + 0x03D, // Size: 6, Flags: PRIVATE, OWNER, UNIT_ALL
        UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER       = ObjectField.OBJECT_END + 0x043, // Size: 6, Flags: PRIVATE, OWNER, UNIT_ALL
        UNIT_FIELD_LEVEL                                       = ObjectField.OBJECT_END + 0x049, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_EFFECTIVE_LEVEL                             = ObjectField.OBJECT_END + 0x04A, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_FACTIONTEMPLATE                             = ObjectField.OBJECT_END + 0x04B, // Size: 1, Flags: PUBLIC
        UNIT_VIRTUAL_ITEM_SLOT_ID                              = ObjectField.OBJECT_END + 0x04C, // Size: 3, Flags: PUBLIC
        UNIT_FIELD_FLAGS                                       = ObjectField.OBJECT_END + 0x04F, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_FLAGS_2                                     = ObjectField.OBJECT_END + 0x050, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_FLAGS_3                                     = ObjectField.OBJECT_END + 0x051, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_AURASTATE                                   = ObjectField.OBJECT_END + 0x052, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_BASEATTACKTIME                              = ObjectField.OBJECT_END + 0x053, // Size: 2, Flags: PUBLIC
        UNIT_FIELD_RANGEDATTACKTIME                            = ObjectField.OBJECT_END + 0x055, // Size: 1, Flags: PRIVATE
        UNIT_FIELD_BOUNDINGRADIUS                              = ObjectField.OBJECT_END + 0x056, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_COMBATREACH                                 = ObjectField.OBJECT_END + 0x057, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_DISPLAYID                                   = ObjectField.OBJECT_END + 0x058, // Size: 1, Flags: DYNAMIC, URGENT
        UNIT_FIELD_NATIVEDISPLAYID                             = ObjectField.OBJECT_END + 0x059, // Size: 1, Flags: PUBLIC, URGENT
        UNIT_FIELD_MOUNTDISPLAYID                              = ObjectField.OBJECT_END + 0x05A, // Size: 1, Flags: PUBLIC, URGENT
        UNIT_FIELD_MINDAMAGE                                   = ObjectField.OBJECT_END + 0x05B, // Size: 1, Flags: PRIVATE, OWNER, SPECIAL_INFO
        UNIT_FIELD_MAXDAMAGE                                   = ObjectField.OBJECT_END + 0x05C, // Size: 1, Flags: PRIVATE, OWNER, SPECIAL_INFO
        UNIT_FIELD_MINOFFHANDDAMAGE                            = ObjectField.OBJECT_END + 0x05D, // Size: 1, Flags: PRIVATE, OWNER, SPECIAL_INFO
        UNIT_FIELD_MAXOFFHANDDAMAGE                            = ObjectField.OBJECT_END + 0x05E, // Size: 1, Flags: PRIVATE, OWNER, SPECIAL_INFO
        UNIT_FIELD_BYTES_1                                     = ObjectField.OBJECT_END + 0x05F, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_PETNUMBER                                   = ObjectField.OBJECT_END + 0x060, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_PET_NAME_TIMESTAMP                          = ObjectField.OBJECT_END + 0x061, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_PETEXPERIENCE                               = ObjectField.OBJECT_END + 0x062, // Size: 1, Flags: OWNER
        UNIT_FIELD_PETNEXTLEVELEXP                             = ObjectField.OBJECT_END + 0x063, // Size: 1, Flags: OWNER
        UNIT_MOD_CAST_SPEED                                    = ObjectField.OBJECT_END + 0x064, // Size: 1, Flags: PUBLIC
        UNIT_MOD_CAST_HASTE                                    = ObjectField.OBJECT_END + 0x065, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_MOD_HASTE                                   = ObjectField.OBJECT_END + 0x066, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_MOD_RANGED_HASTE                            = ObjectField.OBJECT_END + 0x067, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_MOD_HASTE_REGEN                             = ObjectField.OBJECT_END + 0x068, // Size: 1, Flags: PUBLIC
        UNIT_CREATED_BY_SPELL                                  = ObjectField.OBJECT_END + 0x069, // Size: 1, Flags: PUBLIC
        UNIT_NPC_FLAGS                                         = ObjectField.OBJECT_END + 0x06A, // Size: 2, Flags: PUBLIC, DYNAMIC
        UNIT_NPC_EMOTESTATE                                    = ObjectField.OBJECT_END + 0x06C, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_STAT                                        = ObjectField.OBJECT_END + 0x06D, // Size: 5, Flags: PRIVATE, OWNER
        UNIT_FIELD_POSSTAT                                     = ObjectField.OBJECT_END + 0x072, // Size: 5, Flags: PRIVATE, OWNER
        UNIT_FIELD_NEGSTAT                                     = ObjectField.OBJECT_END + 0x077, // Size: 5, Flags: PRIVATE, OWNER
        UNIT_FIELD_RESISTANCES                                 = ObjectField.OBJECT_END + 0x07C, // Size: 7, Flags: PRIVATE, OWNER, SPECIAL_INFO
        UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE                  = ObjectField.OBJECT_END + 0x083, // Size: 7, Flags: PRIVATE, OWNER
        UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE                  = ObjectField.OBJECT_END + 0x08A, // Size: 7, Flags: PRIVATE, OWNER
        UNIT_FIELD_MOD_BONUS_ARMOR                             = ObjectField.OBJECT_END + 0x091, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_BASE_MANA                                   = ObjectField.OBJECT_END + 0x092, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_BASE_HEALTH                                 = ObjectField.OBJECT_END + 0x093, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_BYTES_2                                     = ObjectField.OBJECT_END + 0x094, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_ATTACK_POWER                                = ObjectField.OBJECT_END + 0x095, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_ATTACK_POWER_MOD_POS                        = ObjectField.OBJECT_END + 0x096, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_ATTACK_POWER_MOD_NEG                        = ObjectField.OBJECT_END + 0x097, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_ATTACK_POWER_MULTIPLIER                     = ObjectField.OBJECT_END + 0x098, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_RANGED_ATTACK_POWER                         = ObjectField.OBJECT_END + 0x099, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_RANGED_ATTACK_POWER_MOD_POS                 = ObjectField.OBJECT_END + 0x09A, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_RANGED_ATTACK_POWER_MOD_NEG                 = ObjectField.OBJECT_END + 0x09B, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER              = ObjectField.OBJECT_END + 0x09C, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_MINRANGEDDAMAGE                             = ObjectField.OBJECT_END + 0x09D, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_MAXRANGEDDAMAGE                             = ObjectField.OBJECT_END + 0x09E, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_POWER_COST_MODIFIER                         = ObjectField.OBJECT_END + 0x09F, // Size: 7, Flags: PRIVATE, OWNER
        UNIT_FIELD_POWER_COST_MULTIPLIER                       = ObjectField.OBJECT_END + 0x0A6, // Size: 7, Flags: PRIVATE, OWNER
        UNIT_FIELD_MAXHEALTHMODIFIER                           = ObjectField.OBJECT_END + 0x0AD, // Size: 1, Flags: PRIVATE, OWNER
        UNIT_FIELD_HOVERHEIGHT                                 = ObjectField.OBJECT_END + 0x0AE, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_MIN_ITEM_LEVEL_CUTOFF                       = ObjectField.OBJECT_END + 0x0AF, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_MIN_ITEM_LEVEL                              = ObjectField.OBJECT_END + 0x0B0, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_MAXITEMLEVEL                                = ObjectField.OBJECT_END + 0x0B1, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_WILD_BATTLEPET_LEVEL                        = ObjectField.OBJECT_END + 0x0B2, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_BATTLEPET_COMPANION_NAME_TIMESTAMP          = ObjectField.OBJECT_END + 0x0B3, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_INTERACT_SPELLID                            = ObjectField.OBJECT_END + 0x0B4, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_STATE_SPELL_VISUAL_ID                       = ObjectField.OBJECT_END + 0x0B5, // Size: 1, Flags: DYNAMIC, URGENT
        UNIT_FIELD_STATE_ANIM_ID                               = ObjectField.OBJECT_END + 0x0B6, // Size: 1, Flags: DYNAMIC, URGENT
        UNIT_FIELD_STATE_ANIM_KIT_ID                           = ObjectField.OBJECT_END + 0x0B7, // Size: 1, Flags: DYNAMIC, URGENT
        UNIT_FIELD_STATE_WORLD_EFFECT_ID                       = ObjectField.OBJECT_END + 0x0B8, // Size: 4, Flags: DYNAMIC, URGENT
        UNIT_FIELD_SCALE_DURATION                              = ObjectField.OBJECT_END + 0x0BC, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_LOOKS_LIKE_MOUNT_ID                         = ObjectField.OBJECT_END + 0x0BD, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_LOOKS_LIKE_CREATURE_ID                      = ObjectField.OBJECT_END + 0x0BE, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_LOOK_AT_CONTROLLER_ID                       = ObjectField.OBJECT_END + 0x0BF, // Size: 1, Flags: PUBLIC
        UNIT_FIELD_LOOK_AT_CONTROLLER_TARGET                   = ObjectField.OBJECT_END + 0x0C0, // Size: 4, Flags: PUBLIC
        UNIT_END                                               = ObjectField.OBJECT_END + 0x0C4,
    }

    public enum UnitDynamicField
    {
        UNIT_DYNAMIC_FIELD_PASSIVE_SPELLS                      = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000, // Flags: PUBLIC, URGENT
        UNIT_DYNAMIC_FIELD_WORLD_EFFECTS                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x001, // Flags: PUBLIC, URGENT
        UNIT_DYNAMIC_END                                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x002,
    }

    public enum PlayerField
    {
        PLAYER_DUEL_ARBITER                                    = UnitField.UNIT_END + 0x000, // Size: 4, Flags: PUBLIC
        PLAYER_WOW_ACCOUNT                                     = UnitField.UNIT_END + 0x004, // Size: 4, Flags: PUBLIC
        PLAYER_LOOT_TARGET_GUID                                = UnitField.UNIT_END + 0x008, // Size: 4, Flags: PUBLIC
        PLAYER_FLAGS                                           = UnitField.UNIT_END + 0x00C, // Size: 1, Flags: PUBLIC
        PLAYER_FLAGS_EX                                        = UnitField.UNIT_END + 0x00D, // Size: 1, Flags: PUBLIC
        PLAYER_GUILDRANK                                       = UnitField.UNIT_END + 0x00E, // Size: 1, Flags: PUBLIC
        PLAYER_GUILDDELETE_DATE                                = UnitField.UNIT_END + 0x00F, // Size: 1, Flags: PUBLIC
        PLAYER_GUILDLEVEL                                      = UnitField.UNIT_END + 0x010, // Size: 1, Flags: PUBLIC
        PLAYER_BYTES                                           = UnitField.UNIT_END + 0x011, // Size: 1, Flags: PUBLIC
        PLAYER_BYTES_2                                         = UnitField.UNIT_END + 0x012, // Size: 1, Flags: PUBLIC
        PLAYER_BYTES_3                                         = UnitField.UNIT_END + 0x013, // Size: 1, Flags: PUBLIC
        PLAYER_DUEL_TEAM                                       = UnitField.UNIT_END + 0x014, // Size: 1, Flags: PUBLIC
        PLAYER_GUILD_TIMESTAMP                                 = UnitField.UNIT_END + 0x015, // Size: 1, Flags: PUBLIC
        PLAYER_QUEST_LOG                                       = UnitField.UNIT_END + 0x016, // Size: 750, Flags: PARTY_MEMBER
        PLAYER_VISIBLE_ITEM                                    = UnitField.UNIT_END + 0x304, // Size: 57, Flags: PUBLIC
        PLAYER_CHOSEN_TITLE                                    = UnitField.UNIT_END + 0x33D, // Size: 1, Flags: PUBLIC
        PLAYER_FAKE_INEBRIATION                                = UnitField.UNIT_END + 0x33E, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_VIRTUAL_PLAYER_REALM                      = UnitField.UNIT_END + 0x33F, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_CURRENT_SPEC_ID                           = UnitField.UNIT_END + 0x340, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_TAXI_MOUNT_ANIM_KIT_ID                    = UnitField.UNIT_END + 0x341, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_AVG_ITEM_LEVEL_TOTAL                      = UnitField.UNIT_END + 0x342, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_AVG_ITEM_LEVEL_EQUIPPED                   = UnitField.UNIT_END + 0x343, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_CURRENT_BATTLE_PET_BREED_QUALITY          = UnitField.UNIT_END + 0x344, // Size: 1, Flags: PUBLIC
        PLAYER_FIELD_INV_SLOT_HEAD                             = UnitField.UNIT_END + 0x345, // Size: 736, Flags: PRIVATE
        PLAYER_FARSIGHT                                        = UnitField.UNIT_END + 0x625, // Size: 4, Flags: PRIVATE
        PLAYER__FIELD_KNOWN_TITLES                             = UnitField.UNIT_END + 0x629, // Size: 10, Flags: PRIVATE
        PLAYER_FIELD_COINAGE                                   = UnitField.UNIT_END + 0x633, // Size: 2, Flags: PRIVATE
        PLAYER_XP                                              = UnitField.UNIT_END + 0x635, // Size: 1, Flags: PRIVATE
        PLAYER_NEXT_LEVEL_XP                                   = UnitField.UNIT_END + 0x636, // Size: 1, Flags: PRIVATE
        PLAYER_SKILL_LINEID                                    = UnitField.UNIT_END + 0x637, // Size: 448, Flags: PRIVATE
        PLAYER_CHARACTER_POINTS                                = UnitField.UNIT_END + 0x7F7, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_MAX_TALENT_TIERS                          = UnitField.UNIT_END + 0x7F8, // Size: 1, Flags: PRIVATE
        PLAYER_TRACK_CREATURES                                 = UnitField.UNIT_END + 0x7F9, // Size: 1, Flags: PRIVATE
        PLAYER_TRACK_RESOURCES                                 = UnitField.UNIT_END + 0x7FA, // Size: 1, Flags: PRIVATE
        PLAYER_EXPERTISE                                       = UnitField.UNIT_END + 0x7FB, // Size: 1, Flags: PRIVATE
        PLAYER_OFFHAND_EXPERTISE                               = UnitField.UNIT_END + 0x7FC, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_RANGED_EXPERTISE                          = UnitField.UNIT_END + 0x7FD, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_COMBAT_RATING_EXPERTISE                   = UnitField.UNIT_END + 0x7FE, // Size: 1, Flags: PRIVATE
        PLAYER_BLOCK_PERCENTAGE                                = UnitField.UNIT_END + 0x7FF, // Size: 1, Flags: PRIVATE
        PLAYER_DODGE_PERCENTAGE                                = UnitField.UNIT_END + 0x800, // Size: 1, Flags: PRIVATE
        PLAYER_PARRY_PERCENTAGE                                = UnitField.UNIT_END + 0x801, // Size: 1, Flags: PRIVATE
        PLAYER_CRIT_PERCENTAGE                                 = UnitField.UNIT_END + 0x802, // Size: 1, Flags: PRIVATE
        PLAYER_RANGED_CRIT_PERCENTAGE                          = UnitField.UNIT_END + 0x803, // Size: 1, Flags: PRIVATE
        PLAYER_OFFHAND_CRIT_PERCENTAGE                         = UnitField.UNIT_END + 0x804, // Size: 1, Flags: PRIVATE
        PLAYER_SPELL_CRIT_PERCENTAGE1                          = UnitField.UNIT_END + 0x805, // Size: 7, Flags: PRIVATE
        PLAYER_SHIELD_BLOCK                                    = UnitField.UNIT_END + 0x80C, // Size: 1, Flags: PRIVATE
        PLAYER_SHIELD_BLOCK_CRIT_PERCENTAGE                    = UnitField.UNIT_END + 0x80D, // Size: 1, Flags: PRIVATE
        PLAYER_MASTERY                                         = UnitField.UNIT_END + 0x80E, // Size: 1, Flags: PRIVATE
        PLAYER_AMPLIFY                                         = UnitField.UNIT_END + 0x80F, // Size: 1, Flags: PRIVATE
        PLAYER_MULTISTRIKE                                     = UnitField.UNIT_END + 0x810, // Size: 1, Flags: PRIVATE
        PLAYER_MULTISTRIKE_EFFECT                              = UnitField.UNIT_END + 0x811, // Size: 1, Flags: PRIVATE
        PLAYER_READINESS                                       = UnitField.UNIT_END + 0x812, // Size: 1, Flags: PRIVATE
        PLAYER_SPEED                                           = UnitField.UNIT_END + 0x813, // Size: 1, Flags: PRIVATE
        PLAYER_LIFESTEAL                                       = UnitField.UNIT_END + 0x814, // Size: 1, Flags: PRIVATE
        PLAYER_AVOIDANCE                                       = UnitField.UNIT_END + 0x815, // Size: 1, Flags: PRIVATE
        PLAYER_STURDINESS                                      = UnitField.UNIT_END + 0x816, // Size: 1, Flags: PRIVATE
        PLAYER_CLEAVE                                          = UnitField.UNIT_END + 0x817, // Size: 1, Flags: PRIVATE
        PLAYER_VERSATILITY                                     = UnitField.UNIT_END + 0x818, // Size: 1, Flags: PRIVATE
        PLAYER_VERSATILITY_BONUS                               = UnitField.UNIT_END + 0x819, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_PVP_POWER_DAMAGE                          = UnitField.UNIT_END + 0x81A, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_PVP_POWER_HEALING                         = UnitField.UNIT_END + 0x81B, // Size: 1, Flags: PRIVATE
        PLAYER_EXPLORED_ZONES_1                                = UnitField.UNIT_END + 0x81C, // Size: 200, Flags: PRIVATE
        PLAYER_REST_STATE_EXPERIENCE                           = UnitField.UNIT_END + 0x8E4, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_MOD_DAMAGE_DONE_POS                       = UnitField.UNIT_END + 0x8E5, // Size: 7, Flags: PRIVATE
        PLAYER_FIELD_MOD_DAMAGE_DONE_NEG                       = UnitField.UNIT_END + 0x8EC, // Size: 7, Flags: PRIVATE
        PLAYER_FIELD_MOD_DAMAGE_DONE_PCT                       = UnitField.UNIT_END + 0x8F3, // Size: 7, Flags: PRIVATE
        PLAYER_FIELD_MOD_HEALING_DONE_POS                      = UnitField.UNIT_END + 0x8FA, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_MOD_HEALING_PCT                           = UnitField.UNIT_END + 0x8FB, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_MOD_HEALING_DONE_PCT                      = UnitField.UNIT_END + 0x8FC, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_MOD_PERIODIC_HEALING_DONE_PERCENT         = UnitField.UNIT_END + 0x8FD, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_WEAPON_DMG_MULTIPLIERS                    = UnitField.UNIT_END + 0x8FE, // Size: 3, Flags: PRIVATE
        PLAYER_FIELD_WEAPON_ATK_SPEED_MULTIPLIERS              = UnitField.UNIT_END + 0x901, // Size: 3, Flags: PRIVATE
        PLAYER_FIELD_MOD_SPELL_POWER_PCT                       = UnitField.UNIT_END + 0x904, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_MOD_RESILIENCE_PERCENT                    = UnitField.UNIT_END + 0x905, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_OVERRIDE_SPELL_POWER_BY_AP_PCT            = UnitField.UNIT_END + 0x906, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_OVERRIDE_AP_BY_SPELL_POWER_PERCENT        = UnitField.UNIT_END + 0x907, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_MOD_TARGET_RESISTANCE                     = UnitField.UNIT_END + 0x908, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE            = UnitField.UNIT_END + 0x909, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_LOCAL_FLAGS                               = UnitField.UNIT_END + 0x90A, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_BYTES                                     = UnitField.UNIT_END + 0x90B, // Size: 1, Flags: PRIVATE
        PLAYER_SELF_RES_SPELL                                  = UnitField.UNIT_END + 0x90C, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_PVP_MEDALS                                = UnitField.UNIT_END + 0x90D, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_BUYBACK_PRICE_1                           = UnitField.UNIT_END + 0x90E, // Size: 12, Flags: PRIVATE
        PLAYER_FIELD_BUYBACK_TIMESTAMP_1                       = UnitField.UNIT_END + 0x91A, // Size: 12, Flags: PRIVATE
        PLAYER_FIELD_KILLS                                     = UnitField.UNIT_END + 0x926, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_LIFETIME_HONORABLE_KILLS                  = UnitField.UNIT_END + 0x927, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_WATCHED_FACTION_INDEX                     = UnitField.UNIT_END + 0x928, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_COMBAT_RATING_1                           = UnitField.UNIT_END + 0x929, // Size: 32, Flags: PRIVATE
        PLAYER_FIELD_ARENA_TEAM_INFO_1_1                       = UnitField.UNIT_END + 0x949, // Size: 36, Flags: PRIVATE
        PLAYER_FIELD_MAX_LEVEL                                 = UnitField.UNIT_END + 0x96D, // Size: 1, Flags: PRIVATE
        PLAYER_RUNE_REGEN_1                                    = UnitField.UNIT_END + 0x96E, // Size: 4, Flags: PRIVATE
        PLAYER_NO_REAGENT_COST_1                               = UnitField.UNIT_END + 0x972, // Size: 4, Flags: PRIVATE
        PLAYER_FIELD_GLYPH_SLOTS_1                             = UnitField.UNIT_END + 0x976, // Size: 6, Flags: PRIVATE
        PLAYER_FIELD_GLYPHS_1                                  = UnitField.UNIT_END + 0x97C, // Size: 6, Flags: PRIVATE
        PLAYER_GLYPHS_ENABLED                                  = UnitField.UNIT_END + 0x982, // Size: 1, Flags: PRIVATE
        PLAYER_PET_SPELL_POWER                                 = UnitField.UNIT_END + 0x983, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_RESEARCHING_1                             = UnitField.UNIT_END + 0x984, // Size: 10, Flags: PRIVATE
        PLAYER_PROFESSION_SKILL_LINE_1                         = UnitField.UNIT_END + 0x98E, // Size: 2, Flags: PRIVATE
        PLAYER_FIELD_UI_HIT_MODIFIER                           = UnitField.UNIT_END + 0x990, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_UI_SPELL_HIT_MODIFIER                     = UnitField.UNIT_END + 0x991, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_HOME_REALM_TIME_OFFSET                    = UnitField.UNIT_END + 0x992, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_MOD_PET_HASTE                             = UnitField.UNIT_END + 0x993, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_SUMMONED_BATTLE_PET_ID                    = UnitField.UNIT_END + 0x994, // Size: 4, Flags: PRIVATE
        PLAYER_FIELD_BYTES2                                    = UnitField.UNIT_END + 0x998, // Size: 1, Flags: PRIVATE, URGENT_SELF_ONLY
        PLAYER_FIELD_LFG_BONUS_FACTION_ID                      = UnitField.UNIT_END + 0x999, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_LOOT_SPEC_ID                              = UnitField.UNIT_END + 0x99A, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_OVERRIDE_ZONE_PVP_TYPE                    = UnitField.UNIT_END + 0x99B, // Size: 1, Flags: PRIVATE, URGENT_SELF_ONLY
        PLAYER_FIELD_ITEM_LEVEL_DELTA                          = UnitField.UNIT_END + 0x99C, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_BAG_SLOT_FLAGS                            = UnitField.UNIT_END + 0x99D, // Size: 4, Flags: PRIVATE
        PLAYER_FIELD_BANK_BAG_SLOT_FLAGS                       = UnitField.UNIT_END + 0x9A1, // Size: 7, Flags: PRIVATE
        PLAYER_FIELD_INSERT_ITEMS_LEFT_TO_RIGHT                = UnitField.UNIT_END + 0x9A8, // Size: 1, Flags: PRIVATE
        PLAYER_FIELD_QUEST_COMPLETED                           = UnitField.UNIT_END + 0x9A9, // Size: 625, Flags: PRIVATE
        PLAYER_END                                             = UnitField.UNIT_END + 0xC1A,
    }

    public enum PlayerDynamicField
    {
        PLAYER_DYNAMIC_FIELD_RESERACH_SITE                     = UnitDynamicField.UNIT_DYNAMIC_END + 0x000, // Flags: PRIVATE
        PLAYER_DYNAMIC_FIELD_RESEARCH_SITE_PROGRESS            = UnitDynamicField.UNIT_DYNAMIC_END + 0x001, // Flags: PRIVATE
        PLAYER_DYNAMIC_FIELD_DAILY_QUESTS                      = UnitDynamicField.UNIT_DYNAMIC_END + 0x002, // Flags: PRIVATE
        PLAYER_DYNAMIC_FIELD_AVAILABLE_QUEST_LINE_X_QUEST_ID   = UnitDynamicField.UNIT_DYNAMIC_END + 0x003, // Flags: PRIVATE
        PLAYER_DYNAMIC_FIELD_HEIRLOOMS                         = UnitDynamicField.UNIT_DYNAMIC_END + 0x004, // Flags: PRIVATE
        PLAYER_DYNAMIC_FIELD_HEIRLOOM_FLAGS                    = UnitDynamicField.UNIT_DYNAMIC_END + 0x005, // Flags: PRIVATE
        PLAYER_DYNAMIC_FIELD_TOYS                              = UnitDynamicField.UNIT_DYNAMIC_END + 0x006, // Flags: PRIVATE
        PLAYER_DYNAMIC_END                                     = UnitDynamicField.UNIT_DYNAMIC_END + 0x007,
    }

    public enum GameObjectField
    {
        GAMEOBJECT_FIELD_CREATED_BY                            = ObjectField.OBJECT_END + 0x000, // Size: 4, Flags: PUBLIC
        GAMEOBJECT_DISPLAYID                                   = ObjectField.OBJECT_END + 0x004, // Size: 1, Flags: DYNAMIC, URGENT
        GAMEOBJECT_FLAGS                                       = ObjectField.OBJECT_END + 0x005, // Size: 1, Flags: PUBLIC, URGENT
        GAMEOBJECT_PARENTROTATION                              = ObjectField.OBJECT_END + 0x006, // Size: 4, Flags: PUBLIC
        GAMEOBJECT_FACTION                                     = ObjectField.OBJECT_END + 0x00A, // Size: 1, Flags: PUBLIC
        GAMEOBJECT_LEVEL                                       = ObjectField.OBJECT_END + 0x00B, // Size: 1, Flags: PUBLIC
        GAMEOBJECT_BYTES_1                                     = ObjectField.OBJECT_END + 0x00C, // Size: 1, Flags: PUBLIC, URGENT
        GAMEOBJECT_SPELL_VISUAL_ID                             = ObjectField.OBJECT_END + 0x00D, // Size: 1, Flags: PUBLIC, URGENT
        GAMEOBJECT_STATE_SPELL_VISUAL_ID                       = ObjectField.OBJECT_END + 0x00E, // Size: 1, Flags: DYNAMIC, URGENT
        GAMEOBJECT_STATE_ANIM_ID                               = ObjectField.OBJECT_END + 0x00F, // Size: 1, Flags: DYNAMIC, URGENT
        GAMEOBJECT_STATE_ANIM_KIT_ID                           = ObjectField.OBJECT_END + 0x010, // Size: 1, Flags: DYNAMIC, URGENT
        GAMEOBJECT_STATE_WORLD_EFFECT_ID                       = ObjectField.OBJECT_END + 0x011, // Size: 4, Flags: DYNAMIC, URGENT
        GAMEOBJECT_END                                         = ObjectField.OBJECT_END + 0x015,
    }

    public enum GameObjectDynamicField
    {
        GAMEOBJECT_DYNAMIC_END                                 = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
    }

    public enum DynamicObjectField
    {
        DYNAMICOBJECT_CASTER                                   = ObjectField.OBJECT_END + 0x000, // Size: 4, Flags: PUBLIC
        DYNAMICOBJECT_BYTES                                    = ObjectField.OBJECT_END + 0x004, // Size: 1, Flags: DYNAMIC
        DYNAMICOBJECT_SPELLID                                  = ObjectField.OBJECT_END + 0x005, // Size: 1, Flags: PUBLIC
        DYNAMICOBJECT_RADIUS                                   = ObjectField.OBJECT_END + 0x006, // Size: 1, Flags: PUBLIC
        DYNAMICOBJECT_CASTTIME                                 = ObjectField.OBJECT_END + 0x007, // Size: 1, Flags: PUBLIC
        DYNAMICOBJECT_END                                      = ObjectField.OBJECT_END + 0x008,
    }

    public enum DynamicObjectDynamicField
    {
        DYNAMICOBJECT_DYNAMIC_END                              = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
    }

    public enum CorpseField
    {
        CORPSE_FIELD_OWNER                                     = ObjectField.OBJECT_END + 0x000, // Size: 4, Flags: PUBLIC
        CORPSE_FIELD_PARTY                                     = ObjectField.OBJECT_END + 0x004, // Size: 4, Flags: PUBLIC
        CORPSE_FIELD_DISPLAY_ID                                = ObjectField.OBJECT_END + 0x008, // Size: 1, Flags: PUBLIC
        CORPSE_FIELD_ITEM                                      = ObjectField.OBJECT_END + 0x009, // Size: 19, Flags: PUBLIC
        CORPSE_FIELD_BYTES_1                                   = ObjectField.OBJECT_END + 0x01C, // Size: 1, Flags: PUBLIC
        CORPSE_FIELD_BYTES_2                                   = ObjectField.OBJECT_END + 0x01D, // Size: 1, Flags: PUBLIC
        CORPSE_FIELD_FLAGS                                     = ObjectField.OBJECT_END + 0x01E, // Size: 1, Flags: PUBLIC
        CORPSE_FIELD_DYNAMIC_FLAGS                             = ObjectField.OBJECT_END + 0x01F, // Size: 1, Flags: DYNAMIC
        CORPSE_FIELD_FACTIONTEMPLATE                           = ObjectField.OBJECT_END + 0x020, // Size: 1, Flags: PUBLIC
        CORPSE_END                                             = ObjectField.OBJECT_END + 0x021,
    }

    public enum CorpseDynamicField
    {
        CORPSE_DYNAMIC_END                                     = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
    }

    public enum AreaTriggerField
    {
        AREATRIGGER_CASTER                                     = ObjectField.OBJECT_END + 0x000, // Size: 4, Flags: PUBLIC
        AREATRIGGER_DURATION                                   = ObjectField.OBJECT_END + 0x004, // Size: 1, Flags: PUBLIC
        AREATRIGGER_SPELLID                                    = ObjectField.OBJECT_END + 0x005, // Size: 1, Flags: PUBLIC
        AREATRIGGER_SPELLVISUALID                              = ObjectField.OBJECT_END + 0x006, // Size: 1, Flags: DYNAMIC
        AREATRIGGER_EXPLICIT_SCALE                             = ObjectField.OBJECT_END + 0x007, // Size: 1, Flags: PUBLIC, URGENT
        AREATRIGGER_END                                        = ObjectField.OBJECT_END + 0x008,
    }

    public enum AreaTriggerDynamicField
    {
        AREATRIGGER_DYNAMIC_END                                = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
    }

    public enum SceneObjectField
    {
        SCENEOBJECT_FIELD_SCRIPT_PACKAGE_ID                    = ObjectField.OBJECT_END + 0x000, // Size: 1, Flags: PUBLIC
        SCENEOBJECT_FIELD_RND_SEED_VAL                         = ObjectField.OBJECT_END + 0x001, // Size: 1, Flags: PUBLIC
        SCENEOBJECT_FIELD_CREATEDBY                            = ObjectField.OBJECT_END + 0x002, // Size: 4, Flags: PUBLIC
        SCENEOBJECT_FIELD_SCENE_TYPE                           = ObjectField.OBJECT_END + 0x006, // Size: 1, Flags: PUBLIC
        SCENEOBJECT_END                                        = ObjectField.OBJECT_END + 0x007,
    }

    public enum SceneObjectDynamicField
    {
        SCENEOBJECT_DYNAMIC_END                                = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000,
    }

    public enum ConversationField
    {
        CONVERSATION_FIELD_DUMMY                               = ObjectField.OBJECT_END + 0x000, // Size: 1, Flags: PRIVATE
        CONVERSATION_END                                       = ObjectField.OBJECT_END + 0x001,
    }

    public enum ConversationDynamicField
    {
        CONVERSATION_DYNAMIC_FIELD_ACTORS                      = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x000, // Flags: PUBLIC
        CONVERSATION_DYNAMIC_FIELD_LINES                       = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x001, // Flags: 0x100
        CONVERSATION_DYNAMIC_END                               = ObjectDynamicField.OBJECT_DYNAMIC_END + 0x002,
    }
    // ReSharper restore InconsistentNaming
}
