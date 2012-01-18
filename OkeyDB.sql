CREATE DATABASE  IF NOT EXISTS `okey` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `okey`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: okey
-- ------------------------------------------------------
-- Server version	5.5.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `purchases`
--

DROP TABLE IF EXISTS `purchases`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchases` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `profileId` bigint(20) NOT NULL,
  `itemId` int(11) NOT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchases`
--

LOCK TABLES `purchases` WRITE;
/*!40000 ALTER TABLE `purchases` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchases` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chiphistory`
--

DROP TABLE IF EXISTS `chiphistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chiphistory` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` bigint(20) NOT NULL,
  `gameId` int(11) DEFAULT NULL,
  `netChange` bigint(20) DEFAULT NULL,
  `createDate` datetime DEFAULT NULL,
  PRIMARY KEY (`id`,`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chiphistory`
--

LOCK TABLES `chiphistory` WRITE;
/*!40000 ALTER TABLE `chiphistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `chiphistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usergifts`
--

DROP TABLE IF EXISTS `usergifts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usergifts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `giftId` int(11) NOT NULL,
  `fromId` bigint(20) NOT NULL,
  `toId` bigint(20) NOT NULL,
  `price` int(11) NOT NULL,
  `createDate` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usergifts`
--

LOCK TABLES `usergifts` WRITE;
/*!40000 ALTER TABLE `usergifts` DISABLE KEYS */;
/*!40000 ALTER TABLE `usergifts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `refs`
--

DROP TABLE IF EXISTS `refs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `refs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ip` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `ref` varchar(100) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `refs`
--

LOCK TABLES `refs` WRITE;
/*!40000 ALTER TABLE `refs` DISABLE KEYS */;
/*!40000 ALTER TABLE `refs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `feedhistory`
--

DROP TABLE IF EXISTS `feedhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `feedhistory` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fieldType` int(11) DEFAULT NULL,
  `feedOwner` bigint(20) DEFAULT NULL,
  `uid` bigint(20) DEFAULT NULL,
  `name` varchar(128) DEFAULT NULL,
  `fuid` bigint(20) DEFAULT NULL,
  `chipDiff` int(11) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feedhistory`
--

LOCK TABLES `feedhistory` WRITE;
/*!40000 ALTER TABLE `feedhistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `feedhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zones`
--

DROP TABLE IF EXISTS `zones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zones` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zones`
--

LOCK TABLES `zones` WRITE;
/*!40000 ALTER TABLE `zones` DISABLE KEYS */;
/*!40000 ALTER TABLE `zones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notifications`
--

DROP TABLE IF EXISTS `notifications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notifications` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fromUid` bigint(20) NOT NULL,
  `fromName` varchar(128) DEFAULT NULL,
  `toUid` bigint(20) NOT NULL DEFAULT '0',
  `type` int(11) DEFAULT NULL,
  `message` varchar(128) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `responded` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`id`,`toUid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notifications`
--

LOCK TABLES `notifications` WRITE;
/*!40000 ALTER TABLE `notifications` DISABLE KEYS */;
/*!40000 ALTER TABLE `notifications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rooms`
--

DROP TABLE IF EXISTS `rooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rooms` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `zoneId` int(11) NOT NULL,
  `name` varchar(80) DEFAULT NULL,
  `maxUsers` int(11) DEFAULT NULL,
  `minChips` bigint(20) DEFAULT NULL,
  `priority` int(11) DEFAULT NULL,
  `maxChips` bigint(20) DEFAULT NULL,
  `minEntry` bigint(20) DEFAULT NULL,
  `static1` bigint(20) DEFAULT NULL,
  `static2` bigint(20) DEFAULT NULL,
  `static3` bigint(20) DEFAULT NULL,
  `static4` bigint(20) DEFAULT NULL,
  `static5` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rooms`
--

LOCK TABLES `rooms` WRITE;
/*!40000 ALTER TABLE `rooms` DISABLE KEYS */;
/*!40000 ALTER TABLE `rooms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `complaints`
--

DROP TABLE IF EXISTS `complaints`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `complaints` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `reporter` bigint(20) DEFAULT NULL,
  `reported` bigint(20) DEFAULT NULL,
  `type` varchar(20) DEFAULT NULL,
  `chatLog` varchar(1024) DEFAULT NULL,
  `comment` varchar(1024) DEFAULT NULL,
  `createDate` datetime DEFAULT NULL,
  `action` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `complaints`
--

LOCK TABLES `complaints` WRITE;
/*!40000 ALTER TABLE `complaints` DISABLE KEYS */;
/*!40000 ALTER TABLE `complaints` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventories`
--

DROP TABLE IF EXISTS `inventories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventories` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` bigint(20) NOT NULL DEFAULT '0',
  `type` int(11) DEFAULT NULL,
  `itemId` int(11) DEFAULT NULL,
  `expireDate` datetime DEFAULT NULL,
  `isEquipped` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`id`,`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventories`
--

LOCK TABLES `inventories` WRITE;
/*!40000 ALTER TABLE `inventories` DISABLE KEYS */;
/*!40000 ALTER TABLE `inventories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `friends`
--

DROP TABLE IF EXISTS `friends`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `friends` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` bigint(20) NOT NULL,
  `fuid` bigint(20) NOT NULL,
  `status` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`,`fuid`,`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `friends`
--

LOCK TABLES `friends` WRITE;
/*!40000 ALTER TABLE `friends` DISABLE KEYS */;
/*!40000 ALTER TABLE `friends` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` bigint(20) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `gender` varchar(100) DEFAULT NULL,
  `birthDate` datetime DEFAULT NULL,
  `chips` int(11) DEFAULT NULL,
  `lastSeen` datetime DEFAULT NULL,
  `status` tinyint(4) DEFAULT '0' COMMENT '0 - Normal User\\n1 - VIP User\\n2 - Moderator\\n3 - Admin\\n\\n\\n98 - Suspended\\n99 - Banned',
  `suspendTill` datetime DEFAULT NULL,
  `lastBonusGiven` datetime DEFAULT NULL,
  `name` varchar(255) DEFAULT NULL,
  `friendCount` int(11) DEFAULT '0',
  `registrationDate` datetime DEFAULT NULL,
  `ref` varchar(255) DEFAULT NULL,
  `inviter` varchar(255) DEFAULT NULL,
  `lastIp` varchar(255) DEFAULT NULL,
  `oldChips` int(11) DEFAULT '-1',
  `purchased` tinyint(4) DEFAULT '0',
  `cidtyId` int(11) DEFAULT '-1',
  `grandPrizeGiven` tinyint(4) DEFAULT '0',
  `recommended` int(11) DEFAULT '0',
  `gameCntBonusToday` int(11) DEFAULT '0',
  `weekStartChips` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`,`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gifts`
--

DROP TABLE IF EXISTS `gifts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gifts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `cost` double DEFAULT NULL,
  `className` varchar(100) DEFAULT NULL,
  `categoryId` int(11) DEFAULT NULL,
  `gender` varchar(7) DEFAULT NULL,
  `costType` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gifts`
--

LOCK TABLES `gifts` WRITE;
/*!40000 ALTER TABLE `gifts` DISABLE KEYS */;
/*!40000 ALTER TABLE `gifts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `storeitems`
--

DROP TABLE IF EXISTS `storeitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `storeitems` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(128) DEFAULT NULL,
  `description` varchar(1024) DEFAULT NULL,
  `className` varchar(128) DEFAULT NULL,
  `type` tinyint(4) DEFAULT NULL,
  `isExpirable` tinyint(4) DEFAULT '0',
  `isLimitedTime` tinyint(4) DEFAULT '0',
  `isLimitedCount` tinyint(4) DEFAULT '0',
  `expirePeriod` int(11) DEFAULT NULL,
  `startDate` datetime DEFAULT NULL,
  `endDate` datetime DEFAULT NULL,
  `itemsLeft` int(11) DEFAULT NULL,
  `cost` int(11) DEFAULT NULL,
  `fbCost` int(11) DEFAULT '0',
  `fbRentCost` int(11) DEFAULT '0',
  `friendCost` int(11) DEFAULT '0',
  `featured` tinyint(4) DEFAULT '0',
  `productId` int(11) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `storeitems`
--

LOCK TABLES `storeitems` WRITE;
/*!40000 ALTER TABLE `storeitems` DISABLE KEYS */;
/*!40000 ALTER TABLE `storeitems` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stats`
--

DROP TABLE IF EXISTS `stats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stats` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(50) NOT NULL,
  `value` varchar(50) DEFAULT NULL,
  `createDate` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stats`
--

LOCK TABLES `stats` WRITE;
/*!40000 ALTER TABLE `stats` DISABLE KEYS */;
/*!40000 ALTER TABLE `stats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chatmessages`
--

DROP TABLE IF EXISTS `chatmessages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chatmessages` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `uid` bigint(20) DEFAULT NULL,
  `gameId` int(11) DEFAULT NULL,
  `message` varchar(512) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chatmessages`
--

LOCK TABLES `chatmessages` WRITE;
/*!40000 ALTER TABLE `chatmessages` DISABLE KEYS */;
/*!40000 ALTER TABLE `chatmessages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `weeklytops`
--

DROP TABLE IF EXISTS `weeklytops`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `weeklytops` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `profileId` int(11) DEFAULT NULL,
  `uid` bigint(20) NOT NULL DEFAULT '0',
  `name` varchar(255) DEFAULT NULL,
  `chips` int(11) DEFAULT NULL,
  `weekStartChips` int(11) DEFAULT NULL,
  `delta` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`,`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `weeklytops`
--

LOCK TABLES `weeklytops` WRITE;
/*!40000 ALTER TABLE `weeklytops` DISABLE KEYS */;
/*!40000 ALTER TABLE `weeklytops` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contestusers`
--

DROP TABLE IF EXISTS `contestusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contestusers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `contestId` int(11) NOT NULL,
  `uid` bigint(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contestusers`
--

LOCK TABLES `contestusers` WRITE;
/*!40000 ALTER TABLE `contestusers` DISABLE KEYS */;
/*!40000 ALTER TABLE `contestusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gamehistory`
--

DROP TABLE IF EXISTS `gamehistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gamehistory` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `gameId` int(11) DEFAULT NULL,
  `gameCost` int(11) DEFAULT NULL,
  `gamePot` int(11) DEFAULT NULL,
  `isOkey` tinyint(4) DEFAULT NULL,
  `isCifte` tinyint(4) DEFAULT NULL,
  `isSeri` tinyint(4) DEFAULT '0',
  `userCount` tinyint(4) DEFAULT NULL,
  `user1` bigint(20) DEFAULT NULL,
  `user2` bigint(20) DEFAULT NULL,
  `user3` bigint(20) DEFAULT NULL,
  `user4` bigint(20) DEFAULT NULL,
  `winner` bigint(20) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gamehistory`
--

LOCK TABLES `gamehistory` WRITE;
/*!40000 ALTER TABLE `gamehistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `gamehistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invites`
--

DROP TABLE IF EXISTS `invites`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `invites` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `requestId` varchar(32) DEFAULT NULL,
  `fromUid` bigint(20) DEFAULT NULL,
  `toUid` bigint(20) DEFAULT NULL,
  `accepted` tinyint(4) DEFAULT '0',
  `sendDate` datetime DEFAULT NULL,
  `acceptDate` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invites`
--

LOCK TABLES `invites` WRITE;
/*!40000 ALTER TABLE `invites` DISABLE KEYS */;
/*!40000 ALTER TABLE `invites` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userstats`
--

DROP TABLE IF EXISTS `userstats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userstats` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `profileId` bigint(20) NOT NULL,
  `uid` bigint(20) NOT NULL,
  `firstGamePlayed` int(11) DEFAULT '0',
  `consecutiveWins` int(11) DEFAULT '0',
  `maxConsecutiveWins` int(11) DEFAULT '0',
  `consecutiveLogins` int(11) DEFAULT '0',
  `gamesPlayed` int(11) DEFAULT '0',
  `gamesWon` int(11) DEFAULT '0',
  `gamesRisky` int(11) DEFAULT '0',
  `gamesRiskyWon` int(11) DEFAULT '0',
  `gamesRiskyLost` int(11) DEFAULT '0',
  `maxChipsWon` int(11) DEFAULT '0',
  `maxChips` int(11) DEFAULT '0',
  `gamesPlayedDaily` int(11) DEFAULT '0',
  PRIMARY KEY (`id`,`uid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userstats`
--

LOCK TABLES `userstats` WRITE;
/*!40000 ALTER TABLE `userstats` DISABLE KEYS */;
/*!40000 ALTER TABLE `userstats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(200) DEFAULT NULL,
  `text` varchar(200) DEFAULT NULL,
  `chips` int(11) DEFAULT NULL,
  `fbCredits` int(11) DEFAULT NULL,
  `realMoney` double DEFAULT NULL,
  `discountMoney` double DEFAULT '0',
  `discountFbCredits` int(11) DEFAULT NULL,
  `discountEnabled` tinyint(4) DEFAULT NULL,
  `imageUrl` varchar(200) DEFAULT NULL,
  `productUrl` varchar(200) DEFAULT NULL,
  `storeId` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `announcements`
--

DROP TABLE IF EXISTS `announcements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `announcements` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(256) DEFAULT NULL,
  `text` varchar(1024) DEFAULT NULL,
  `featured` tinyint(4) DEFAULT '0',
  `imageUrl` varchar(256) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `actionLabel` varchar(256) DEFAULT NULL,
  `actionPage` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `announcements`
--

LOCK TABLES `announcements` WRITE;
/*!40000 ALTER TABLE `announcements` DISABLE KEYS */;
/*!40000 ALTER TABLE `announcements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requests`
--

DROP TABLE IF EXISTS `requests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `requests` (
  `id` int(11) NOT NULL,
  `reqId` varchar(255) DEFAULT NULL,
  `reqType` tinyint(4) DEFAULT NULL,
  `from` bigint(20) DEFAULT NULL,
  `to` bigint(20) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requests`
--

LOCK TABLES `requests` WRITE;
/*!40000 ALTER TABLE `requests` DISABLE KEYS */;
/*!40000 ALTER TABLE `requests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `events` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ip` varchar(100) DEFAULT NULL,
  `profileId` bigint(20) DEFAULT NULL,
  `eventName` varchar(30) DEFAULT NULL,
  `value` varchar(11) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `events`
--

LOCK TABLES `events` WRITE;
/*!40000 ALTER TABLE `events` DISABLE KEYS */;
/*!40000 ALTER TABLE `events` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2012-01-18  1:16:17
