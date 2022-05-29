// Decompiled with JetBrains decompiler
// Type: PerfectWorld.PacketSenderNew
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using Skill_Sender;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfectWorld
{
  internal class PacketSenderNew
  {
    private int RBA = 19454876;
    private int PACKT = 10033584;
    private IntPtr pr_processHandle;
    private int roletaranel;
    private byte[] roletaranelrev;
    private byte[] roletaranelpct = new byte[26]
    {
      (byte) 37,
      (byte) 0,
      (byte) 69,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 8,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 167,
      (byte) 19,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 90,
      (byte) 230,
      (byte) 91,
      (byte) 0,
      (byte) 167,
      (byte) 19
    };
    private int EnergVoo;
    private byte[] EnergVooRev;
    private byte[] EnegVooPyk = new byte[4]
    {
      (byte) 43,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int cancelskill;
    private byte[] cancelskilladr;
    private byte[] cancelskillpkt = new byte[2]
    {
      (byte) 42,
      (byte) 0
    };
    private int merdaaddr;
    private byte[] merdaadrred;
    private byte[] merdapkt = new byte[2]
    {
      (byte) 51,
      (byte) 0
    };
    private int dropitemsAddress;
    private byte[] dropitemsddressRev;
    private byte[] dropOutPkt = new byte[7]
    {
      (byte) 14,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int logOutAddress;
    private byte[] logOutAddressRev;
    private byte[] logOutPkt = new byte[6]
    {
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int selectAddress;
    private byte[] selectAddressRev;
    private byte[] selectPkt = new byte[6]
    {
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int regularAttackAddress;
    private byte[] regularAttackAddressRev;
    private byte[] regularAttackPkt = new byte[3]
    {
      (byte) 3,
      (byte) 0,
      (byte) 0
    };
    private int resurrectToTownAddress;
    private byte[] resurrectToTownAddressRev;
    private byte[] resurrectToTownPkt = new byte[2]
    {
      (byte) 4,
      (byte) 0
    };
    private int resurrectWithScrollAddress;
    private byte[] resurrectWithScrollAddressRev;
    private byte[] resurrectWithScrollPkt = new byte[2]
    {
      (byte) 5,
      (byte) 0
    };
    private int pickUpItemAddress;
    private byte[] pickUpItemAddressRev;
    private byte[] pickUpItemPkt = new byte[10]
    {
      (byte) 6,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int updateInvPositionAddress;
    private byte[] updateInvPositionAddressRev;
    private byte[] updateInvPositionPkt = new byte[3]
    {
      (byte) 9,
      (byte) 0,
      (byte) 0
    };
    private int swapItemInInvAddress;
    private byte[] swapItemInInvAddressRev;
    private byte[] swapItemInInvPkt = new byte[4]
    {
      (byte) 12,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int splitStackItemInInvAddress;
    private byte[] splitStackItemInInvAddressRev;
    private byte[] splitStackItemInInvPkt = new byte[6]
    {
      (byte) 13,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int dropItemAddress;
    private byte[] dropItemAddressRev;
    private byte[] dropItemPkt = new byte[5]
    {
      (byte) 14,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int swapItemInEquipAddress;
    private byte[] swapItemInEquipAddressRev;
    private byte[] swapItemInEquipPkt = new byte[4]
    {
      (byte) 16,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int swapEquipWithInvAddress;
    private byte[] swapEquipWithInvAddressRev;
    private byte[] swapEquipWithInvPkt = new byte[4]
    {
      (byte) 17,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int dropGoldAddress;
    private byte[] dropGoldAddressRev;
    private byte[] dropGoldPkt = new byte[6]
    {
      (byte) 20,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int updateStatsAddress;
    private byte[] updateStatsAddressRev;
    private byte[] updateStatsPkt = new byte[2]
    {
      (byte) 21,
      (byte) 0
    };
    private int increaseStatsByAddress;
    private byte[] increaseStatsByAddressRev;
    private byte[] increaseStatsByPkt = new byte[18]
    {
      (byte) 22,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int invitePartyAddress;
    private byte[] invitePartyAddressRev;
    private byte[] invitePartyPkt = new byte[6]
    {
      (byte) 27,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int acceptPartyInviteAddress;
    private byte[] acceptPartyInviteAddressRev;
    private byte[] acceptPartyInvitePkt = new byte[10]
    {
      (byte) 28,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int refusePartyInviteAddress;
    private byte[] refusePartyInviteAddressRev;
    private byte[] refusePartyInvitePkt = new byte[6]
    {
      (byte) 29,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int leavePartyAddress;
    private byte[] leavePartyAddressRev;
    private byte[] leavePartyPkt = new byte[2]
    {
      (byte) 30,
      (byte) 0
    };
    private int evictFromPartyAddress;
    private byte[] evictFromPartyAddressRev;
    private byte[] evictFromPartyPkt = new byte[6]
    {
      (byte) 31,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int startNpcDialogueAddress;
    private byte[] startNpcDialogueAddressRev;
    private byte[] startNpcDialoguePkt = new byte[6]
    {
      (byte) 35,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int useItemAddress;
    private byte[] useItemAddressRev;
    private byte[] useItemPkt = new byte[10]
    {
      (byte) 40,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 183,
      (byte) 0,
      (byte) 0
    };
    private int useSkillddress;
    private byte[] useSkillAddressRev;
    private byte[] useSkillPkt = new byte[16]
    {
      (byte) 41,
      (byte) 0,
      (byte) 241,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 161,
      (byte) 158,
      (byte) 16,
      (byte) 128,
      (byte) 220,
      byte.MaxValue,
      (byte) 63,
      (byte) 1
    };
    private int moveddress;
    private byte[] moveAddressRev;
    private byte[] movePkt = new byte[2]
    {
      (byte) 37,
      (byte) 0
    };
    private int cancelActionAddress;
    private byte[] cancelActionAddressRev;
    private byte[] cancelActionPkt = new byte[2]
    {
      (byte) 42,
      (byte) 0
    };
    private int startMeditatingAddress;
    private byte[] startMeditatingAddressRev;
    private byte[] startMeditatingPkt = new byte[2]
    {
      (byte) 46,
      (byte) 0
    };
    private int stopMeditatingAddress;
    private byte[] stopMeditatingAddressRev;
    private byte[] stopMeditatingPkt = new byte[2]
    {
      (byte) 47,
      (byte) 0
    };
    private int useEmotionAddress;
    private byte[] useEmotionAddressRev;
    private byte[] useEmotionPkt = new byte[4]
    {
      (byte) 48,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int beIntimateAddress;
    private byte[] beIntimateAddressRev;
    private byte[] beIntimatePkt = new byte[4]
    {
      (byte) 48,
      (byte) 0,
      (byte) 29,
      (byte) 0
    };
    private int harvestResourceAddress;
    private byte[] harvestResourceAddressRev;
    private byte[] harvestResourcePkt = new byte[18]
    {
      (byte) 54,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 30,
      (byte) 0,
      (byte) 1,
      (byte) 12,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int swapItemInBankAddress;
    private byte[] swapItemInBankAddressRev;
    private byte[] swapItemInBankPkt = new byte[5]
    {
      (byte) 56,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 0
    };
    private int splitStackItemInBankAddress;
    private byte[] splitStackItemInBankAddressRev;
    private byte[] splitStackItemInBankPkt = new byte[7]
    {
      (byte) 57,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int swapItemBankAndInvAddress;
    private byte[] swapItemBankAndInvAddressRev;
    private byte[] swapItemBankAndInvPkt = new byte[5]
    {
      (byte) 58,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 0
    };
    private int splitStackItemInBankToInvAddress;
    private byte[] splitStackItemInBankToInvAddressRev;
    private byte[] splitStackItemInBankToInvPkt = new byte[7]
    {
      (byte) 59,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int splitStackItemInInvToBankAddress;
    private byte[] splitStackItemInInvToBankAddressRev;
    private byte[] splitStackItemInInvToBankPkt = new byte[7]
    {
      (byte) 60,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int setPartySearchSettingsAddress;
    private byte[] setPartySearchSettingsAddressRev;
    private byte[] setPartySearchSettingsPkt = new byte[10]
    {
      (byte) 63,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int shiftPartyCaptainAddress;
    private byte[] shiftPartyCaptainAddressRev;
    private byte[] shiftPartyCaptainPkt = new byte[6]
    {
      (byte) 72,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int useSkillWithoutCastTimeAddress;
    private byte[] useSkillWithoutCastTimeAddressRev;
    private byte[] useSkillWithoutCastTimePkt = new byte[12]
    {
      (byte) 80,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int initiateSettingUpCatShopAddress;
    private byte[] initiateSettingUpCatShopAddressRev;
    private byte[] initiateSettingUpCatShopPkt = new byte[2]
    {
      (byte) 84,
      (byte) 0
    };
    private int toggleFashionDisplayAddress;
    private byte[] toggleFashionDisplayAddressRev;
    private byte[] toggleFashionDisplayPkt = new byte[2]
    {
      (byte) 85,
      (byte) 0
    };
    private int acceptRessurectByClericAddress;
    private byte[] acceptRessurectByClericAddressRev;
    private byte[] acceptRessurectByClericPkt = new byte[2]
    {
      (byte) 87,
      (byte) 0
    };
    private int increaseFlySpeedAddress;
    private byte[] increaseFlySpeedAddressRev;
    private byte[] increaseFlySpeedPkt = new byte[3]
    {
      (byte) 90,
      (byte) 0,
      (byte) 1
    };
    private int inviteToDuelAddress;
    private byte[] inviteToDuelAddressRev;
    private byte[] inviteToDuelPkt = new byte[6]
    {
      (byte) 92,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int acceptDuelAddress;
    private byte[] acceptDuelAddressRev;
    private byte[] acceptDuelPkt = new byte[6]
    {
      (byte) 93,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int askMaleToCarryAddress;
    private byte[] askMaleToCarryAddressRev;
    private byte[] askMaleToCarryPkt = new byte[6]
    {
      (byte) 94,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int askFemaleToBeCarriedAddress;
    private byte[] askFemaleToBeCarriedAddressRev;
    private byte[] askFemaleToBeCarriedPkt = new byte[6]
    {
      (byte) 95,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int acceptRequestByFemaleToBeCarriedAddress;
    private byte[] acceptRequestByFemaleToBeCarriedAddressRev;
    private byte[] acceptRequestByFemaleToBeCarriedPkt = new byte[10]
    {
      (byte) 96,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int acceptRequestByMaleToCarryYouAddress;
    private byte[] acceptRequestByMaleToCarryYouAddressRev;
    private byte[] acceptRequestByMaleToCarryYouPkt = new byte[10]
    {
      (byte) 97,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int releaseCarryModeAddress;
    private byte[] releaseCarryModeAddressRev;
    private byte[] releaseCarryModePkt = new byte[2]
    {
      (byte) 98,
      (byte) 0
    };
    private int viewPlayerEquipAddress;
    private byte[] viewPlayerEquipAddressRev;
    private byte[] viewPlayerEquipPkt = new byte[6]
    {
      (byte) 99,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int summonPetAddress;
    private byte[] summonPetAddressRev;
    private byte[] summonPetPkt = new byte[6]
    {
      (byte) 100,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int recallPetAddress;
    private byte[] recallPetAddressRev;
    private byte[] recallPetPkt = new byte[2]
    {
      (byte) 101,
      (byte) 0
    };
    private int setPetModeAddress;
    private byte[] setPetModeAddressRev;
    private byte[] setPetModePkt = new byte[14]
    {
      (byte) 103,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int setPetFollowAddress;
    private byte[] setPetFollowAddressRev;
    private byte[] setPetFollowPkt = new byte[14]
    {
      (byte) 103,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int setPetStopAddress;
    private byte[] setPetStopAddressRev;
    private byte[] setPetStopPkt = new byte[14]
    {
      (byte) 103,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int setPetAttackAddress;
    private byte[] setPetAttackAddressRev;
    private byte[] setPetAttackPkt = new byte[11]
    {
      (byte) 103,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int setPetUseSkillAddress;
    private byte[] setPetUseSkillAddressRev;
    private byte[] setPetUseSkillPkt = new byte[15]
    {
      (byte) 103,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 4,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int setPetStandardSkillAddress;
    private byte[] setPetStandardSkillAddressRev;
    private byte[] setPetStandardSkillPkt = new byte[14]
    {
      (byte) 103,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 5,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int useGenieSkillAddress;
    private byte[] useGenieSkillAddressRev;
    private byte[] useGenieSkillPkt = new byte[10]
    {
      (byte) 116,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int feedEquippedGenieAddress;
    private byte[] feedEquippedGenieAddressRev;
    private byte[] feedEquippedGeniePkt = new byte[7]
    {
      (byte) 117,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int acceptQuestAddress;
    private byte[] acceptQuestAddressRev;
    private byte[] acceptQuestPkt = new byte[14]
    {
      (byte) 37,
      (byte) 0,
      (byte) 7,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 4,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int handInQuestAddress;
    private byte[] handInQuestAddressRev;
    private byte[] handInQuestPkt = new byte[18]
    {
      (byte) 37,
      (byte) 0,
      (byte) 6,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 8,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int sellSingleItemAddress;
    private byte[] sellSingleItemAddressRev;
    private byte[] sellSingleItemPkt = new byte[30]
    {
      (byte) 37,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 20,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 137,
      (byte) 7,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int sillAddress;
    private byte[] skillAddressRev;
    private byte[] skill = new byte[14]
    {
      (byte) 41,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 64,
      (byte) 11,
      (byte) 25,
      (byte) 0,
      (byte) 220,
      byte.MaxValue
    };
    private int buySingleItemAddress;
    private byte[] buySingleItemAddressRev;
    private byte[] buySingleItemPkt = new byte[50]
    {
      (byte) 37,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 40,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int repairAllAddress;
    private byte[] repairAllAddressRev;
    private byte[] repairAllPkt = new byte[16]
    {
      (byte) 37,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 6,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    };
    private int repairItemAddress;
    private byte[] repairItemAddressRev;
    private byte[] repairItemPkt = new byte[16]
    {
      (byte) 37,
      (byte) 0,
      (byte) 3,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 6,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue,
      byte.MaxValue,
      (byte) 0,
      (byte) 0
    };
    private int upgradeSkillAddress;
    private byte[] upgradeSkillAddressRev;
    private byte[] upgradeSkillPkt = new byte[14]
    {
      (byte) 37,
      (byte) 0,
      (byte) 9,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 4,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private byte[] sendPacketOpcode = new byte[27]
    {
      (byte) 96,
      (byte) 184,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 139,
      (byte) 13,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 139,
      (byte) 73,
      (byte) 32,
      (byte) 191,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 106,
      (byte) 0,
      (byte) 87,
      byte.MaxValue,
      (byte) 208,
      (byte) 97,
      (byte) 195
    };
    private int packetAddressLocation;
    private int packetSizeAddress;
    private int sendPacketOpcodeAddress;
    private int deselectTargetAddress;
    private byte[] deselectTargetAddressRev;
    private byte[] deselectTargetPkt = new byte[2]
    {
      (byte) 8,
      (byte) 0
    };
    private int forjargetAddress;
    private byte[] forjargetAddressRev;
    private byte[] reforjarPkt = new byte[22]
    {
      (byte) 37,
      (byte) 0,
      (byte) 12,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 12,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int dialogAddress;
    private byte[] dialogtagetAddressRev;
    private byte[] dialogPkt = new byte[6]
    {
      (byte) 35,
      (byte) 0,
      (byte) 80,
      (byte) 139,
      (byte) 16,
      (byte) 128
    };
    private int forjaraneladdress;
    private byte[] forjaraneladdressrev;
    private byte[] forjaranelpkt = new byte[14]
    {
      (byte) 37,
      (byte) 0,
      (byte) 69,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 8,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 253,
      (byte) 2,
      (byte) 1,
      (byte) 0
    };
    private int forjar_Dragao_Errante_address;
    private byte[] forjar_Dragao_Errante_addressrev;
    private byte[] Forjar_Dragao_Errante_Pkt = new byte[22]
    {
      (byte) 37,
      (byte) 0,
      (byte) 12,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 12,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 160,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 27,
      (byte) 4,
      (byte) 0,
      (byte) 0,
      (byte) 1,
      (byte) 0,
      (byte) 0,
      (byte) 0
    };
    private int fornalhaddress;
    private byte[] fornalhaddressrev;
    private byte[] fornalhaptk = new byte[4]
    {
      (byte) 37,
      (byte) 0,
      (byte) 74,
      (byte) 0
    };

    public void RoletarAnel()
    {
      if (this.roletaranel == 0)
        this.loadPacket(this.roletaranelpct, ref this.roletaranel, ref this.roletaranelrev);
      this.sendPacket(this.roletaranelrev, 18);
    }

    public void Energvoo(int index, int stonecout)
    {
      if (this.EnergVoo == 0)
        this.loadPacket(this.EnegVooPyk, ref this.EnergVoo, ref this.EnergVooRev);
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.EnergVoo + 2, BitConverter.GetBytes(index));
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.EnergVoo + 3, BitConverter.GetBytes(stonecout));
      this.sendPacket(this.EnergVooRev, 7);
    }

    public void CancelSkill()
    {
      if (this.cancelskill == 0)
        this.loadPacket(this.cancelskillpkt, ref this.cancelskill, ref this.cancelskilladr);
      this.sendPacket(this.cancelskilladr, 2);
    }

    public void segundoclik()
    {
      if (this.merdaaddr == 0)
        this.loadPacket(this.merdapkt, ref this.merdaaddr, ref this.merdaadrred);
      this.sendPacket(this.merdaadrred, 2);
    }

    public void dropitens(int indexinventario, int quantidade)
    {
      int length = this.dropOutPkt.Length;
      if (this.dropitemsAddress == 0)
        this.loadPacket(this.dropOutPkt, ref this.dropitemsAddress, ref this.dropitemsddressRev);
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.dropitemsAddress + 2, BitConverter.GetBytes(indexinventario));
      byte[] bytes = BitConverter.GetBytes(quantidade);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.dropitemsAddress + 3, bytes);
      this.sendPacket(this.dropitemsddressRev, 7);
    }

    public void logOut(int toAccount)
    {
      int length = this.logOutPkt.Length;
      if (this.logOutAddress == 0)
        this.loadPacket(this.logOutPkt, ref this.logOutAddress, ref this.logOutAddressRev);
      byte[] bytes = BitConverter.GetBytes(toAccount);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.logOutAddress + 2, bytes);
      this.sendPacket(this.logOutAddressRev, length);
    }

    public void select(int objectId)
    {
      int length = this.selectPkt.Length;
      if (this.logOutAddress == 0)
        this.loadPacket(this.selectPkt, ref this.selectAddress, ref this.selectAddressRev);
      byte[] bytes = BitConverter.GetBytes(objectId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.selectAddress + 2, bytes);
      this.sendPacket(this.selectAddressRev, 6);
    }

    public void regularAttack(byte afterSkill)
    {
      int length = this.regularAttackPkt.Length;
      if (this.regularAttackAddress == 0)
        this.loadPacket(this.regularAttackPkt, ref this.regularAttackAddress, ref this.regularAttackAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.regularAttackAddress + 2, afterSkill);
      this.sendPacket(this.regularAttackAddressRev, length);
    }

    public void resurrectToTown()
    {
      int length = this.resurrectToTownPkt.Length;
      if (this.resurrectToTownAddress == 0)
        this.loadPacket(this.resurrectToTownPkt, ref this.resurrectToTownAddress, ref this.resurrectToTownAddressRev);
      this.sendPacket(this.resurrectToTownAddressRev, length);
    }

    public void resurrectWithScroll()
    {
      int length = this.resurrectWithScrollPkt.Length;
      if (this.resurrectWithScrollAddress == 0)
        this.loadPacket(this.resurrectWithScrollPkt, ref this.resurrectWithScrollAddress, ref this.resurrectWithScrollAddressRev);
      this.sendPacket(this.resurrectWithScrollAddressRev, length);
    }

    public void pickUpItem(int uniqueId, int typeId)
    {
      int length = this.pickUpItemPkt.Length;
      if (this.pickUpItemAddress == 0)
        this.loadPacket(this.pickUpItemPkt, ref this.pickUpItemAddress, ref this.pickUpItemAddressRev);
      byte[] bytes1 = BitConverter.GetBytes(uniqueId);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.selectAddress + 2, bytes1);
      byte[] bytes2 = BitConverter.GetBytes(typeId);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.selectAddress + 6, bytes2);
      this.sendPacket(this.pickUpItemAddressRev, length);
    }

    public void updateInvPosition(byte invIndex)
    {
      int length = this.updateInvPositionPkt.Length;
      if (this.updateInvPositionAddress == 0)
        this.loadPacket(this.updateInvPositionPkt, ref this.updateInvPositionAddress, ref this.updateInvPositionAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.updateInvPositionAddress + 2, invIndex);
      this.sendPacket(this.updateInvPositionAddressRev, length);
    }

    public void swapItemInInv(byte invIndex1, byte invIndex2)
    {
      int length = this.swapItemInInvPkt.Length;
      if (this.swapItemInInvAddress == 0)
        this.loadPacket(this.swapItemInInvPkt, ref this.swapItemInInvAddress, ref this.swapItemInInvAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapItemInInvAddress + 2, invIndex1);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapItemInInvAddress + 3, invIndex2);
      this.sendPacket(this.swapItemInInvAddressRev, length);
    }

    public void splitStackInInventory(byte invIndexSource, byte invIndexDestination, short amount)
    {
      int length = this.splitStackItemInInvPkt.Length;
      if (this.splitStackItemInInvAddress == 0)
        this.loadPacket(this.splitStackItemInInvPkt, ref this.splitStackItemInInvAddress, ref this.splitStackItemInInvAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.splitStackItemInInvAddress + 2, invIndexSource);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.splitStackItemInInvAddress + 3, invIndexDestination);
      byte[] bytes = BitConverter.GetBytes(amount);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.splitStackItemInInvAddress + 4, bytes);
      this.sendPacket(this.splitStackItemInInvAddressRev, 8);
    }

    public void dropItem(byte invIndex, short amount)
    {
      int length = this.dropItemPkt.Length;
      if (this.dropItemAddress == 0)
        this.loadPacket(this.dropItemPkt, ref this.dropItemAddress, ref this.dropItemAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.dropItemAddress + 2, invIndex);
      byte[] bytes = BitConverter.GetBytes(amount);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.dropItemAddress + 3, bytes);
      this.sendPacket(this.dropItemAddressRev, 7);
    }

    public void swapItemInEquip(byte equipIndex1, byte equipIndex2)
    {
      int length = this.swapItemInEquipPkt.Length;
      if (this.swapItemInEquipAddress == 0)
        this.loadPacket(this.swapItemInEquipPkt, ref this.swapItemInEquipAddress, ref this.swapItemInEquipAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapItemInEquipAddress + 2, equipIndex1);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapItemInEquipAddress + 3, equipIndex2);
      this.sendPacket(this.swapItemInEquipAddressRev, length);
    }

    public void swapEquipWithInv(byte invIndex, byte equipIndex)
    {
      int length = this.swapEquipWithInvPkt.Length;
      if (this.swapEquipWithInvAddress == 0)
        this.loadPacket(this.swapEquipWithInvPkt, ref this.swapEquipWithInvAddress, ref this.swapEquipWithInvAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapEquipWithInvAddress + 2, invIndex);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapEquipWithInvAddress + 3, equipIndex);
      this.sendPacket(this.swapEquipWithInvAddressRev, length);
    }

    public void dropGold(int amount)
    {
      int length = this.dropGoldPkt.Length;
      if (this.dropGoldAddress == 0)
        this.loadPacket(this.dropGoldPkt, ref this.dropGoldAddress, ref this.dropGoldAddressRev);
      byte[] bytes = BitConverter.GetBytes(amount);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.dropGoldAddress + 2, bytes);
      this.sendPacket(this.dropGoldAddressRev, length);
    }

    public void updateStats()
    {
      int length = this.updateStatsPkt.Length;
      if (this.updateStatsAddress == 0)
        this.loadPacket(this.updateStatsPkt, ref this.updateStatsAddress, ref this.updateStatsAddressRev);
      this.sendPacket(this.updateStatsAddressRev, length);
    }

    public void increaseStatsBy(int constitution, int intelligence, int strength, int agility)
    {
      int length = this.increaseStatsByPkt.Length;
      if (this.increaseStatsByAddress == 0)
        this.loadPacket(this.increaseStatsByPkt, ref this.increaseStatsByAddress, ref this.increaseStatsByAddressRev);
      byte[] bytes1 = BitConverter.GetBytes(constitution);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.increaseStatsByAddress + 2, bytes1);
      byte[] bytes2 = BitConverter.GetBytes(intelligence);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.increaseStatsByAddress + 6, bytes2);
      byte[] bytes3 = BitConverter.GetBytes(strength);
      ((IEnumerable<byte>) bytes3).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.increaseStatsByAddress + 10, bytes3);
      byte[] bytes4 = BitConverter.GetBytes(agility);
      ((IEnumerable<byte>) bytes4).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.increaseStatsByAddress + 14, bytes4);
      this.sendPacket(this.increaseStatsByAddressRev, length);
    }

    public void inviteParty(int playerId)
    {
      int length = this.invitePartyPkt.Length;
      if (this.invitePartyAddress == 0)
        this.loadPacket(this.invitePartyPkt, ref this.invitePartyAddress, ref this.invitePartyAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.invitePartyAddress + 2, bytes);
      this.sendPacket(this.invitePartyAddressRev, length);
    }

    public void acceptPartyInvite(int playerId, int partyInviteCounter)
    {
      int length = this.acceptPartyInvitePkt.Length;
      if (this.acceptPartyInviteAddress == 0)
        this.loadPacket(this.acceptPartyInvitePkt, ref this.acceptPartyInviteAddress, ref this.acceptPartyInviteAddressRev);
      byte[] bytes1 = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.acceptPartyInviteAddress + 2, bytes1);
      byte[] bytes2 = BitConverter.GetBytes(partyInviteCounter);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.acceptPartyInviteAddress + 6, bytes2);
      this.sendPacket(this.acceptPartyInviteAddressRev, length);
    }

    public void refusePartyInvite(int playerId)
    {
      int length = this.refusePartyInvitePkt.Length;
      if (this.refusePartyInviteAddress == 0)
        this.loadPacket(this.refusePartyInvitePkt, ref this.refusePartyInviteAddress, ref this.refusePartyInviteAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.refusePartyInviteAddress + 2, bytes);
      this.sendPacket(this.refusePartyInviteAddressRev, length);
    }

    public void leaveParty()
    {
      int length = this.leavePartyPkt.Length;
      if (this.leavePartyAddress == 0)
        this.loadPacket(this.leavePartyPkt, ref this.leavePartyAddress, ref this.leavePartyAddressRev);
      this.sendPacket(this.leavePartyAddressRev, length);
    }

    public void evictFromParty(int playerId)
    {
      int length = this.evictFromPartyPkt.Length;
      if (this.evictFromPartyAddress == 0)
        this.loadPacket(this.evictFromPartyPkt, ref this.evictFromPartyAddress, ref this.evictFromPartyAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.evictFromPartyAddress + 2, bytes);
      this.sendPacket(this.evictFromPartyAddressRev, length);
    }

    public void startNpcDialogue(int npcId)
    {
      int length = this.startNpcDialoguePkt.Length;
      if (this.startNpcDialogueAddress == 0)
        this.loadPacket(this.startNpcDialoguePkt, ref this.startNpcDialogueAddress, ref this.startNpcDialogueAddressRev);
      byte[] bytes = BitConverter.GetBytes(npcId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.startNpcDialogueAddress + 2, bytes);
      this.sendPacket(this.startNpcDialogueAddressRev, length);
    }

    public void useItem(byte isEquip, byte itemIndex, int typeId)
    {
      int length = this.useItemPkt.Length;
      if (this.useItemAddress == 0)
        this.loadPacket(this.useItemPkt, ref this.useItemAddress, ref this.useItemAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.useItemAddress + 3, isEquip);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.useItemAddress + 4, itemIndex);
      byte[] bytes = BitConverter.GetBytes(typeId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.useItemAddress + 6, bytes);
      this.sendPacket(this.useItemAddressRev, 10);
    }

    public void useSkill(int skillId, uint targetId)
    {
      int length = this.useSkillPkt.Length;
      if (this.useSkillddress == 0)
        this.loadPacket(this.useSkillPkt, ref this.useSkillddress, ref this.useSkillAddressRev);
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.useSkillddress + 2, BitConverter.GetBytes(skillId));
      this.sendPacket(this.useSkillAddressRev, 12);
    }

    public void move()
    {
      int length = this.useSkillPkt.Length;
      if (this.useSkillddress == 0)
        this.loadPacket(this.movePkt, ref this.moveddress, ref this.moveAddressRev);
      this.sendPacket(this.moveAddressRev, 33);
    }

    public void cancelAction()
    {
      int length = this.cancelActionPkt.Length;
      if (this.cancelActionAddress == 0)
        this.loadPacket(this.cancelActionPkt, ref this.cancelActionAddress, ref this.cancelActionAddressRev);
      this.sendPacket(this.cancelActionAddressRev, length);
    }

    public void startMeditating()
    {
      int length = this.startMeditatingPkt.Length;
      if (this.startMeditatingAddress == 0)
        this.loadPacket(this.startMeditatingPkt, ref this.startMeditatingAddress, ref this.startMeditatingAddressRev);
      this.sendPacket(this.startMeditatingAddressRev, length);
    }

    public void stopMeditating()
    {
      int length = this.stopMeditatingPkt.Length;
      if (this.stopMeditatingAddress == 0)
        this.loadPacket(this.stopMeditatingPkt, ref this.stopMeditatingAddress, ref this.stopMeditatingAddressRev);
      this.sendPacket(this.stopMeditatingAddressRev, length);
    }

    public void useEmotion(short emoteId)
    {
      int length = this.useEmotionPkt.Length;
      if (this.useEmotionAddress == 0)
        this.loadPacket(this.useEmotionPkt, ref this.useEmotionAddress, ref this.useEmotionAddressRev);
      byte[] bytes = BitConverter.GetBytes(emoteId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.useEmotionAddress, bytes);
      this.sendPacket(this.useEmotionAddressRev, length);
    }

    public void beIntimate()
    {
      int length = this.beIntimatePkt.Length;
      if (this.beIntimateAddress == 0)
        this.loadPacket(this.beIntimatePkt, ref this.beIntimateAddress, ref this.beIntimateAddressRev);
      this.sendPacket(this.beIntimateAddressRev, length);
    }

    public void harvestResource(int uniqueId)
    {
      int length = this.harvestResourcePkt.Length;
      if (this.harvestResourceAddress == 0)
        this.loadPacket(this.harvestResourcePkt, ref this.harvestResourceAddress, ref this.harvestResourceAddressRev);
      byte[] bytes = BitConverter.GetBytes(uniqueId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.harvestResourceAddress + 2, bytes);
      this.sendPacket(this.harvestResourceAddressRev, length);
    }

    public void swapItemInBank(byte bankIndex1, byte bankIndex2)
    {
      int length = this.swapItemInBankPkt.Length;
      if (this.swapItemInBankAddress == 0)
        this.loadPacket(this.swapItemInBankPkt, ref this.swapItemInBankAddress, ref this.swapItemInBankAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapEquipWithInvAddress + 3, bankIndex1);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapEquipWithInvAddress + 4, bankIndex2);
      this.sendPacket(this.swapItemInBankAddressRev, length);
    }

    public void splitStackItemInBank(byte bankIndexSource, byte bankIndexDestination, short amount)
    {
      int length = this.splitStackItemInBankPkt.Length;
      if (this.splitStackItemInBankAddress == 0)
        this.loadPacket(this.splitStackItemInBankPkt, ref this.splitStackItemInBankAddress, ref this.splitStackItemInBankAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.splitStackItemInBankAddress + 3, bankIndexSource);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.splitStackItemInBankAddress + 4, bankIndexSource);
      byte[] bytes = BitConverter.GetBytes(amount);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.splitStackItemInBankAddress + 5, bytes);
      this.sendPacket(this.splitStackItemInBankAddressRev, length);
    }

    public void swapItemBankAndInv(byte bankIndex, byte invIndex)
    {
      int length = this.swapItemBankAndInvPkt.Length;
      if (this.swapItemBankAndInvAddress == 0)
        this.loadPacket(this.swapItemBankAndInvPkt, ref this.swapItemBankAndInvAddress, ref this.swapItemBankAndInvAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapItemBankAndInvAddress + 3, bankIndex);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.swapItemBankAndInvAddress + 4, invIndex);
      this.sendPacket(this.swapItemBankAndInvAddressRev, length);
    }

    public void splitStackItemInBankToInv(byte bankIndex, byte invIndex, short amount)
    {
      int length = this.splitStackItemInBankToInvPkt.Length;
      if (this.splitStackItemInBankToInvAddress == 0)
        this.loadPacket(this.splitStackItemInBankToInvPkt, ref this.splitStackItemInBankToInvAddress, ref this.splitStackItemInBankToInvAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.splitStackItemInBankToInvAddress + 3, bankIndex);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.splitStackItemInBankToInvAddress + 4, invIndex);
      byte[] bytes = BitConverter.GetBytes(amount);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.splitStackItemInBankToInvAddress + 5, bytes);
      this.sendPacket(this.splitStackItemInBankToInvAddressRev, length);
    }

    public void splitStackItemInInvToBank(byte invIndex, byte bankIndex, short amount)
    {
      int length = this.splitStackItemInInvToBankPkt.Length;
      if (this.splitStackItemInInvToBankAddress == 0)
        this.loadPacket(this.splitStackItemInInvToBankPkt, ref this.splitStackItemInInvToBankAddress, ref this.splitStackItemInInvToBankAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.splitStackItemInInvToBankAddress + 3, invIndex);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.splitStackItemInInvToBankAddress + 4, bankIndex);
      byte[] bytes = BitConverter.GetBytes(amount);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.splitStackItemInInvToBankAddress + 5, bytes);
      this.sendPacket(this.splitStackItemInInvToBankAddressRev, length);
    }

    public void setPartySearchSettings(byte jobId, byte lvl, byte recruit, byte slogan)
    {
      int length = this.setPartySearchSettingsPkt.Length;
      if (this.setPartySearchSettingsAddress == 0)
        this.loadPacket(this.setPartySearchSettingsPkt, ref this.setPartySearchSettingsAddress, ref this.setPartySearchSettingsAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.setPartySearchSettingsAddress + 2, jobId);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.setPartySearchSettingsAddress + 3, lvl);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.setPartySearchSettingsAddress + 4, recruit);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.setPartySearchSettingsAddress + 5, slogan);
      this.sendPacket(this.setPartySearchSettingsAddressRev, length);
    }

    public void shiftPartyCaptain(int playerId)
    {
      int length = this.shiftPartyCaptainPkt.Length;
      if (this.shiftPartyCaptainAddress == 0)
        this.loadPacket(this.shiftPartyCaptainPkt, ref this.shiftPartyCaptainAddress, ref this.shiftPartyCaptainAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.shiftPartyCaptainAddress + 2, bytes);
      this.sendPacket(this.shiftPartyCaptainAddressRev, length);
    }

    public void useSkillWithoutCastTime(int skillId, int targetId)
    {
      int length = this.useSkillWithoutCastTimePkt.Length;
      if (this.useSkillWithoutCastTimeAddress == 0)
        this.loadPacket(this.useSkillWithoutCastTimePkt, ref this.useSkillWithoutCastTimeAddress, ref this.useSkillWithoutCastTimeAddressRev);
      byte[] bytes1 = BitConverter.GetBytes(skillId);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.useSkillWithoutCastTimeAddress + 2, bytes1);
      byte[] bytes2 = BitConverter.GetBytes(targetId);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.useSkillWithoutCastTimeAddress + 8, bytes2);
      this.sendPacket(this.useSkillWithoutCastTimeAddressRev, length);
    }

    public void initiateSettingUpCatShop()
    {
      int length = this.initiateSettingUpCatShopPkt.Length;
      if (this.initiateSettingUpCatShopAddress == 0)
        this.loadPacket(this.initiateSettingUpCatShopPkt, ref this.initiateSettingUpCatShopAddress, ref this.initiateSettingUpCatShopAddressRev);
      this.sendPacket(this.initiateSettingUpCatShopAddressRev, length);
    }

    public void toggleFashionDisplay()
    {
      int length = this.toggleFashionDisplayPkt.Length;
      if (this.toggleFashionDisplayAddress == 0)
        this.loadPacket(this.toggleFashionDisplayPkt, ref this.toggleFashionDisplayAddress, ref this.toggleFashionDisplayAddressRev);
      this.sendPacket(this.toggleFashionDisplayAddressRev, length);
    }

    public void acceptRessurectByCleric()
    {
      int length = this.acceptRessurectByClericPkt.Length;
      if (this.acceptRessurectByClericAddress == 0)
        this.loadPacket(this.acceptRessurectByClericPkt, ref this.acceptRessurectByClericAddress, ref this.acceptRessurectByClericAddressRev);
      this.sendPacket(this.acceptRessurectByClericAddressRev, length);
    }

    public void increaseFlySpeed()
    {
      int length = this.increaseFlySpeedPkt.Length;
      if (this.increaseFlySpeedAddress == 0)
        this.loadPacket(this.increaseFlySpeedPkt, ref this.increaseFlySpeedAddress, ref this.increaseFlySpeedAddressRev);
      this.sendPacket(this.increaseFlySpeedAddressRev, 6);
    }

    public void inviteToDuel(int playerId)
    {
      int length = this.inviteToDuelPkt.Length;
      if (this.inviteToDuelAddress == 0)
        this.loadPacket(this.inviteToDuelPkt, ref this.inviteToDuelAddress, ref this.inviteToDuelAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.inviteToDuelAddress + 2, bytes);
      this.sendPacket(this.inviteToDuelAddressRev, length);
    }

    public void acceptDuel(int playerId)
    {
      int length = this.acceptDuelPkt.Length;
      if (this.acceptDuelAddress == 0)
        this.loadPacket(this.acceptDuelPkt, ref this.acceptDuelAddress, ref this.acceptDuelAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.acceptDuelAddress + 2, bytes);
      this.sendPacket(this.acceptDuelAddressRev, length);
    }

    public void askMaleToCarry(int playerId)
    {
      int length = this.askMaleToCarryPkt.Length;
      if (this.askMaleToCarryAddress == 0)
        this.loadPacket(this.askMaleToCarryPkt, ref this.askMaleToCarryAddress, ref this.askMaleToCarryAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.askMaleToCarryAddress + 2, bytes);
      this.sendPacket(this.askMaleToCarryAddressRev, length);
    }

    public void askFemaleToBeCarried(int playerId)
    {
      int length = this.askFemaleToBeCarriedPkt.Length;
      if (this.askFemaleToBeCarriedAddress == 0)
        this.loadPacket(this.askFemaleToBeCarriedPkt, ref this.askFemaleToBeCarriedAddress, ref this.askFemaleToBeCarriedAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.askFemaleToBeCarriedAddress + 2, bytes);
      this.sendPacket(this.askFemaleToBeCarriedAddressRev, length);
    }

    public void acceptRequestByFemaleToBeCarried(int playerId)
    {
      int length = this.acceptRequestByFemaleToBeCarriedPkt.Length;
      if (this.acceptRequestByFemaleToBeCarriedAddress == 0)
        this.loadPacket(this.acceptRequestByFemaleToBeCarriedPkt, ref this.acceptRequestByFemaleToBeCarriedAddress, ref this.acceptRequestByFemaleToBeCarriedAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.acceptRequestByFemaleToBeCarriedAddress + 2, bytes);
      this.sendPacket(this.acceptRequestByFemaleToBeCarriedAddressRev, length);
    }

    public void acceptRequestByMaleToCarryYou(int playerId)
    {
      int length = this.acceptRequestByMaleToCarryYouPkt.Length;
      if (this.acceptRequestByMaleToCarryYouAddress == 0)
        this.loadPacket(this.acceptRequestByMaleToCarryYouPkt, ref this.acceptRequestByMaleToCarryYouAddress, ref this.acceptRequestByMaleToCarryYouAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.acceptRequestByMaleToCarryYouAddress + 2, bytes);
      this.sendPacket(this.acceptRequestByMaleToCarryYouAddressRev, length);
    }

    public void releaseCarryMode()
    {
      int length = this.releaseCarryModePkt.Length;
      if (this.releaseCarryModeAddress == 0)
        this.loadPacket(this.releaseCarryModePkt, ref this.releaseCarryModeAddress, ref this.releaseCarryModeAddressRev);
      this.sendPacket(this.releaseCarryModeAddressRev, length);
    }

    public void viewPlayerEquip(int playerId)
    {
      int length = this.viewPlayerEquipPkt.Length;
      if (this.viewPlayerEquipAddress == 0)
        this.loadPacket(this.viewPlayerEquipPkt, ref this.viewPlayerEquipAddress, ref this.viewPlayerEquipAddressRev);
      byte[] bytes = BitConverter.GetBytes(playerId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.viewPlayerEquipAddress + 2, bytes);
      this.sendPacket(this.viewPlayerEquipAddressRev, length);
    }

    public void summonPet(int petIndex)
    {
      int length = this.summonPetPkt.Length;
      if (this.summonPetAddress == 0)
        this.loadPacket(this.summonPetPkt, ref this.summonPetAddress, ref this.summonPetAddressRev);
      byte[] bytes = BitConverter.GetBytes(petIndex);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.summonPetAddress + 2, bytes);
      this.sendPacket(this.summonPetAddressRev, length);
    }

    public void recallPet()
    {
      int length = this.recallPetPkt.Length;
      if (this.recallPetAddress == 0)
        this.loadPacket(this.recallPetPkt, ref this.recallPetAddress, ref this.recallPetAddressRev);
      this.sendPacket(this.recallPetAddressRev, length);
    }

    public void setPetMode(int petMode)
    {
      int length = this.setPetModePkt.Length;
      if (this.setPetModeAddress == 0)
        this.loadPacket(this.setPetModePkt, ref this.setPetModeAddress, ref this.setPetModeAddressRev);
      byte[] bytes = BitConverter.GetBytes(petMode);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.setPetModeAddress + 10, bytes);
      this.sendPacket(this.setPetModeAddressRev, length);
    }

    public void setPetFollow()
    {
      int length = this.setPetFollowPkt.Length;
      if (this.setPetFollowAddress == 0)
        this.loadPacket(this.setPetFollowPkt, ref this.setPetFollowAddress, ref this.setPetFollowAddressRev);
      this.sendPacket(this.setPetFollowAddressRev, length);
    }

    public void setPetStop()
    {
      int length = this.setPetStopPkt.Length;
      if (this.setPetStopAddress == 0)
        this.loadPacket(this.setPetStopPkt, ref this.setPetStopAddress, ref this.setPetStopAddressRev);
      this.sendPacket(this.setPetStopAddressRev, length);
    }

    public void setPetAttack(int targetId)
    {
      int length = this.setPetAttackPkt.Length;
      if (this.setPetAttackAddress == 0)
        this.loadPacket(this.setPetAttackPkt, ref this.setPetAttackAddress, ref this.setPetAttackAddressRev);
      byte[] bytes = BitConverter.GetBytes(targetId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.setPetAttackAddress + 2, bytes);
      this.sendPacket(this.setPetAttackAddressRev, length);
    }

    public void setPetUseSkill(int targetId, int skillId)
    {
      int length = this.setPetUseSkillPkt.Length;
      if (this.setPetUseSkillAddress == 0)
        this.loadPacket(this.setPetUseSkillPkt, ref this.setPetUseSkillAddress, ref this.setPetUseSkillAddressRev);
      byte[] bytes1 = BitConverter.GetBytes(targetId);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.setPetUseSkillAddress + 2, bytes1);
      byte[] bytes2 = BitConverter.GetBytes(skillId);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.setPetUseSkillAddress + 10, bytes2);
      this.sendPacket(this.setPetUseSkillAddressRev, length);
    }

    public void setPetStandardSkill(int skillId)
    {
      int length = this.setPetStandardSkillPkt.Length;
      if (this.setPetStandardSkillAddress == 0)
        this.loadPacket(this.setPetStandardSkillPkt, ref this.setPetStandardSkillAddress, ref this.setPetStandardSkillAddressRev);
      byte[] bytes = BitConverter.GetBytes(skillId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.setPetStandardSkillAddress + 10, bytes);
      this.sendPacket(this.setPetStandardSkillAddressRev, length);
    }

    public void useGenieSkill(short skillId, int targetId)
    {
      int length = this.useGenieSkillPkt.Length;
      if (this.useGenieSkillAddress == 0)
        this.loadPacket(this.useGenieSkillPkt, ref this.useGenieSkillAddress, ref this.useGenieSkillAddressRev);
      byte[] bytes1 = BitConverter.GetBytes(skillId);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.useGenieSkillAddress + 2, bytes1);
      byte[] bytes2 = BitConverter.GetBytes(targetId);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.useGenieSkillAddress + 6, bytes2);
      this.sendPacket(this.useGenieSkillAddressRev, length);
    }

    public void feedEquippedGenie(byte invIndex, int amount)
    {
      int length = this.feedEquippedGeniePkt.Length;
      if (this.feedEquippedGenieAddress == 0)
        this.loadPacket(this.feedEquippedGeniePkt, ref this.feedEquippedGenieAddress, ref this.feedEquippedGenieAddressRev);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.feedEquippedGenieAddress + 2, invIndex);
      byte[] bytes = BitConverter.GetBytes(amount);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.feedEquippedGenieAddress + 3, bytes);
      this.sendPacket(this.feedEquippedGenieAddressRev, length);
    }

    public void acceptQuest(int questId)
    {
      int length = this.acceptQuestPkt.Length;
      if (this.acceptQuestAddress == 0)
        this.loadPacket(this.acceptQuestPkt, ref this.acceptQuestAddress, ref this.acceptQuestAddressRev);
      byte[] bytes = BitConverter.GetBytes(questId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.acceptQuestAddress + 10, bytes);
      this.sendPacket(this.acceptQuestAddressRev, length);
    }

    public void handInQuest(int questId, int optionIndex)
    {
      int length = this.handInQuestPkt.Length;
      if (this.handInQuestAddress == 0)
        this.loadPacket(this.handInQuestPkt, ref this.handInQuestAddress, ref this.handInQuestAddressRev);
      byte[] bytes1 = BitConverter.GetBytes(questId);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.handInQuestAddress + 10, bytes1);
      byte[] bytes2 = BitConverter.GetBytes(optionIndex);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.handInQuestAddress + 14, bytes2);
      this.sendPacket(this.handInQuestAddressRev, length);
    }

    public void sellSingleItem(int typeId, int invIndex, int amount, int preco)
    {
      int length = this.sellSingleItemPkt.Length;
      if (this.sellSingleItemAddress == 0)
        this.loadPacket(this.sellSingleItemPkt, ref this.sellSingleItemAddress, ref this.sellSingleItemAddressRev);
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.sellSingleItemAddress + 14, BitConverter.GetBytes(typeId));
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.sellSingleItemAddress + 18, BitConverter.GetBytes(invIndex));
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.sellSingleItemAddress + 22, BitConverter.GetBytes(amount));
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.sellSingleItemAddress + 26, BitConverter.GetBytes(preco));
      this.sendPacket(this.sellSingleItemAddressRev, 30);
    }

    public void usarskill(int typeId)
    {
      int length = this.skill.Length;
      if (this.sillAddress == 0)
        this.loadPacket(this.skill, ref this.sillAddress, ref this.skillAddressRev);
      byte[] bytes = BitConverter.GetBytes(typeId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.sillAddress + 2, bytes);
      this.sendPacket(this.skillAddressRev, 12);
    }

    public void buySingleItem(int typeId, int shopIndex, int amount)
    {
      int length = this.buySingleItemPkt.Length;
      if (this.buySingleItemAddress == 0)
        this.loadPacket(this.buySingleItemPkt, ref this.buySingleItemAddress, ref this.buySingleItemAddressRev);
      byte[] bytes1 = BitConverter.GetBytes(typeId);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.buySingleItemAddress + 38, bytes1);
      byte[] bytes2 = BitConverter.GetBytes(shopIndex);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.buySingleItemAddress + 42, bytes2);
      byte[] bytes3 = BitConverter.GetBytes(amount);
      ((IEnumerable<byte>) bytes3).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.buySingleItemAddress + 46, bytes3);
      this.sendPacket(this.buySingleItemAddressRev, 50);
    }

    public void repairAll()
    {
      int length = this.repairAllPkt.Length;
      if (this.repairAllAddress == 0)
        this.loadPacket(this.repairAllPkt, ref this.repairAllAddress, ref this.repairAllAddressRev);
      this.sendPacket(this.repairAllAddressRev, length);
    }

    public void repairItem(int typeId, byte isEquipped, byte locationIndex)
    {
      int length = this.repairItemPkt.Length;
      if (this.repairItemAddress == 0)
        this.loadPacket(this.repairItemPkt, ref this.repairItemAddress, ref this.repairItemAddressRev);
      byte[] bytes = BitConverter.GetBytes(typeId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.repairItemAddress + 10, bytes);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.repairItemAddress + 14, isEquipped);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.repairItemAddress + 15, locationIndex);
      this.sendPacket(this.repairItemAddressRev, length);
    }

    public void upgradeSkill(int skillId)
    {
      int length = this.upgradeSkillPkt.Length;
      if (this.upgradeSkillAddress == 0)
        this.loadPacket(this.upgradeSkillPkt, ref this.upgradeSkillAddress, ref this.upgradeSkillAddressRev);
      byte[] bytes = BitConverter.GetBytes(skillId);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.upgradeSkillAddress + 10, bytes);
      this.sendPacket(this.upgradeSkillAddressRev, length);
    }

    public PacketSenderNew(IntPtr hHandle) => this.pr_processHandle = hHandle;

    public void deselectTarget()
    {
      int length = this.deselectTargetPkt.Length;
      if (this.deselectTargetAddress == 0)
        this.loadPacket(this.deselectTargetPkt, ref this.deselectTargetAddress, ref this.deselectTargetAddressRev);
      this.sendPacket(this.deselectTargetAddressRev, length);
    }

    public void Forjar(int id, int quantidade)
    {
      if (this.forjargetAddress == 0)
        this.loadPacket(this.reforjarPkt, ref this.forjargetAddress, ref this.forjargetAddressRev);
      byte[] bytes1 = BitConverter.GetBytes(id);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.forjargetAddress + 14, bytes1);
      byte[] bytes2 = BitConverter.GetBytes(1);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.forjargetAddress + 16, bytes2);
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.forjargetAddress + 18, BitConverter.GetBytes(quantidade));
      this.sendPacket(this.forjargetAddressRev, 22);
    }

    public void DialogNPC(uint npcID)
    {
      if (this.dialogAddress == 0)
        this.loadPacket(this.dialogPkt, ref this.dialogAddress, ref this.dialogtagetAddressRev);
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.dialogAddress + 2, BitConverter.GetBytes(npcID));
      this.sendPacket(this.dialogtagetAddressRev, 6);
    }

    public void adicionarAddAnel()
    {
      if (this.forjaraneladdress == 0)
        this.loadPacket(this.forjaranelpkt, ref this.forjaraneladdress, ref this.forjaraneladdressrev);
      this.sendPacket(this.forjaraneladdressrev, 18);
    }

    private void loadSendPacketOpcode()
    {
      this.sendPacketOpcodeAddress = MemFunctions.AllocateMemory(this.pr_processHandle, this.sendPacketOpcode.Length);
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.sendPacketOpcodeAddress, this.sendPacketOpcode);
      byte[] bytes1 = BitConverter.GetBytes(this.PACKT);
      ((IEnumerable<byte>) bytes1).Reverse<byte>();
      byte[] bytes2 = BitConverter.GetBytes(this.RBA);
      ((IEnumerable<byte>) bytes2).Reverse<byte>();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.sendPacketOpcodeAddress + 2, bytes1);
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.sendPacketOpcodeAddress + 8, bytes2);
      this.packetAddressLocation = this.sendPacketOpcodeAddress + 16;
      this.packetSizeAddress = this.sendPacketOpcodeAddress + 21;
    }

    public void Forjar_Dragao_Errante()
    {
      if (this.forjar_Dragao_Errante_address == 0)
        this.loadPacket(this.Forjar_Dragao_Errante_Pkt, ref this.forjar_Dragao_Errante_address, ref this.forjar_Dragao_Errante_addressrev);
      this.sendPacket(this.forjar_Dragao_Errante_addressrev, 22);
    }

    public void ForjarFornalha(byte botao)
    {
      if (this.fornalhaddress == 0)
        this.loadPacket(this.fornalhaptk, ref this.fornalhaddress, ref this.fornalhaddressrev);
      ((IEnumerable<byte>) BitConverter.GetBytes((short) botao)).Reverse<byte>();
      this.sendPacket(this.fornalhaddressrev, this.fornalhaptk.Length);
    }

    public void sendPacket(byte[] packetLocation, int packetSize)
    {
      if (this.sendPacketOpcodeAddress == 0)
        this.loadSendPacketOpcode();
      MemFunctions.MemWriteBytes(this.pr_processHandle, this.packetAddressLocation, packetLocation);
      MemFunctions.MemWriteByte(this.pr_processHandle, this.packetSizeAddress, (byte) packetSize);
      IntPtr remoteThread = MemFunctions.CreateRemoteThread(this.pr_processHandle, this.sendPacketOpcodeAddress);
      MemFunctions.WaitForSingleObject(remoteThread);
      MemFunctions.CloseProcess(remoteThread);
    }

    private void loadPacket(byte[] packet, ref int packetAddress, ref byte[] packetAddressRev)
    {
      packetAddress = MemFunctions.AllocateMemory(this.pr_processHandle, packet.Length);
      MemFunctions.MemWriteBytes(this.pr_processHandle, packetAddress, packet);
      packetAddressRev = BitConverter.GetBytes(packetAddress);
      ((IEnumerable<byte>) packetAddressRev).Reverse<byte>();
    }

    ~PacketSenderNew()
    {
      if (this.roletaranel != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.roletaranel);
      if (this.cancelskill != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.cancelskill);
      if (this.fornalhaddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.fornalhaddress);
      if (this.forjar_Dragao_Errante_address != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.forjar_Dragao_Errante_address);
      if (this.forjaraneladdress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.forjaraneladdress);
      if (this.forjargetAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.forjargetAddress);
      if (this.packetAddressLocation != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.packetAddressLocation);
      if (this.packetSizeAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.packetSizeAddress);
      if (this.sendPacketOpcodeAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.sendPacketOpcodeAddress);
      if (this.deselectTargetAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.deselectTargetAddress);
      if (this.acceptDuelAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.acceptDuelAddress);
      if (this.acceptPartyInviteAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.acceptPartyInviteAddress);
      if (this.acceptQuestAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.acceptQuestAddress);
      if (this.acceptRequestByFemaleToBeCarriedAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.acceptRequestByFemaleToBeCarriedAddress);
      if (this.acceptRequestByMaleToCarryYouAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.acceptRequestByMaleToCarryYouAddress);
      if (this.acceptRessurectByClericAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.acceptRessurectByClericAddress);
      if (this.askFemaleToBeCarriedAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.askFemaleToBeCarriedAddress);
      if (this.askMaleToCarryAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.askMaleToCarryAddress);
      if (this.beIntimateAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.beIntimateAddress);
      if (this.buySingleItemAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.buySingleItemAddress);
      if (this.cancelActionAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.cancelActionAddress);
      if (this.dropGoldAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.dropGoldAddress);
      if (this.dropItemAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.dropItemAddress);
      if (this.evictFromPartyAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.evictFromPartyAddress);
      if (this.feedEquippedGenieAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.feedEquippedGenieAddress);
      if (this.handInQuestAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.handInQuestAddress);
      if (this.harvestResourceAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.harvestResourceAddress);
      if (this.increaseFlySpeedAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.increaseFlySpeedAddress);
      if (this.increaseStatsByAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.increaseStatsByAddress);
      if (this.increaseStatsByAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.increaseStatsByAddress);
      if (this.initiateSettingUpCatShopAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.initiateSettingUpCatShopAddress);
      if (this.invitePartyAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.invitePartyAddress);
      if (this.inviteToDuelAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.inviteToDuelAddress);
      if (this.leavePartyAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.leavePartyAddress);
      if (this.logOutAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.logOutAddress);
      if (this.pickUpItemAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.pickUpItemAddress);
      if (this.recallPetAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.recallPetAddress);
      if (this.refusePartyInviteAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.refusePartyInviteAddress);
      if (this.regularAttackAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.regularAttackAddress);
      if (this.releaseCarryModeAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.releaseCarryModeAddress);
      if (this.repairAllAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.repairAllAddress);
      if (this.repairItemAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.repairItemAddress);
      if (this.resurrectToTownAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.resurrectToTownAddress);
      if (this.resurrectWithScrollAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.resurrectWithScrollAddress);
      if (this.selectAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.selectAddress);
      if (this.sellSingleItemAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.sellSingleItemAddress);
      if (this.setPartySearchSettingsAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.setPartySearchSettingsAddress);
      if (this.setPetAttackAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.setPetAttackAddress);
      if (this.setPetFollowAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.setPetFollowAddress);
      if (this.setPetModeAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.setPetModeAddress);
      if (this.setPetStandardSkillAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.setPetStandardSkillAddress);
      if (this.setPetStopAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.setPetStopAddress);
      if (this.setPetUseSkillAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.setPetUseSkillAddress);
      if (this.shiftPartyCaptainAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.shiftPartyCaptainAddress);
      if (this.splitStackItemInBankAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.splitStackItemInBankAddress);
      if (this.splitStackItemInBankToInvAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.splitStackItemInBankToInvAddress);
      if (this.splitStackItemInInvAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.splitStackItemInInvAddress);
      if (this.splitStackItemInInvToBankAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.splitStackItemInInvToBankAddress);
      if (this.startMeditatingAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.startMeditatingAddress);
      if (this.startNpcDialogueAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.startNpcDialogueAddress);
      if (this.stopMeditatingAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.stopMeditatingAddress);
      if (this.summonPetAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.summonPetAddress);
      if (this.swapEquipWithInvAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.swapEquipWithInvAddress);
      if (this.swapItemBankAndInvAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.swapItemBankAndInvAddress);
      if (this.swapItemInBankAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.swapItemInBankAddress);
      if (this.swapItemInEquipAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.swapItemInEquipAddress);
      if (this.swapItemInInvAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.swapItemInInvAddress);
      if (this.toggleFashionDisplayAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.toggleFashionDisplayAddress);
      if (this.updateInvPositionAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.updateInvPositionAddress);
      if (this.updateStatsAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.updateStatsAddress);
      if (this.upgradeSkillAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.upgradeSkillAddress);
      if (this.useEmotionAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.useEmotionAddress);
      if (this.useGenieSkillAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.useGenieSkillAddress);
      if (this.useItemAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.useItemAddress);
      if (this.useSkillddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.useSkillddress);
      if (this.useSkillWithoutCastTimeAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.useSkillWithoutCastTimeAddress);
      if (this.viewPlayerEquipAddress != 0)
        MemFunctions.FreeMemory(this.pr_processHandle, this.viewPlayerEquipAddress);
      if (this.sillAddress == 0)
        return;
      MemFunctions.FreeMemory(this.pr_processHandle, this.sillAddress);
    }
  }
}
