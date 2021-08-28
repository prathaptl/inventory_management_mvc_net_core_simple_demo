/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 80022
 Source Host           : localhost:3306
 Source Schema         : inventory_management

 Target Server Type    : MySQL
 Target Server Version : 80022
 File Encoding         : 65001

 Date: 27/08/2021 13:01:01
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for products
-- ----------------------------
DROP TABLE IF EXISTS `products`;
CREATE TABLE `products`  (
  `Id` int(0) NOT NULL AUTO_INCREMENT,
  `Code` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CurrentQty` decimal(19, 3) NULL DEFAULT NULL,
  `Price` decimal(10, 2) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for role_privileges
-- ----------------------------
DROP TABLE IF EXISTS `role_privileges`;
CREATE TABLE `role_privileges`  (
  `Id` int(0) NOT NULL AUTO_INCREMENT,
  `RoleId` int(0) NOT NULL,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Value` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Id`) USING BTREE,
  INDEX `fk_role_privileges_RoleId`(`RoleId`) USING BTREE,
  CONSTRAINT `fk_role_privileges_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `user_roles` (`Id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 52 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of role_privileges
-- ----------------------------
INSERT INTO `role_privileges` VALUES (1, 1, 'UserIndex', 0);
INSERT INTO `role_privileges` VALUES (2, 1, 'UserRoleDelete', 0);
INSERT INTO `role_privileges` VALUES (3, 1, 'UserRoleEdit', 0);
INSERT INTO `role_privileges` VALUES (4, 1, 'UserRoleAdd', 0);
INSERT INTO `role_privileges` VALUES (5, 1, 'UserDelete', 0);
INSERT INTO `role_privileges` VALUES (6, 1, 'UserEdit', 0);
INSERT INTO `role_privileges` VALUES (7, 1, 'UserAdd', 0);
INSERT INTO `role_privileges` VALUES (8, 1, 'UserRoleIndex', 0);
INSERT INTO `role_privileges` VALUES (9, 1, 'InventorySendInventorySummary', 1);
INSERT INTO `role_privileges` VALUES (10, 1, 'ProductEdit', 0);
INSERT INTO `role_privileges` VALUES (11, 1, 'ProductAdd', 0);
INSERT INTO `role_privileges` VALUES (12, 1, 'ProductIndex', 0);
INSERT INTO `role_privileges` VALUES (13, 1, 'MenuAdministration', 0);
INSERT INTO `role_privileges` VALUES (14, 1, 'MenuInventory', 0);
INSERT INTO `role_privileges` VALUES (15, 1, 'MenuMaterData', 0);
INSERT INTO `role_privileges` VALUES (16, 1, 'ProductDelete', 0);
INSERT INTO `role_privileges` VALUES (17, 2, 'ProductDelete', 1);
INSERT INTO `role_privileges` VALUES (18, 2, 'UserRoleAdd', 0);
INSERT INTO `role_privileges` VALUES (19, 2, 'UserRoleIndex', 0);
INSERT INTO `role_privileges` VALUES (20, 2, 'UserDelete', 0);
INSERT INTO `role_privileges` VALUES (21, 2, 'UserEdit', 0);
INSERT INTO `role_privileges` VALUES (22, 2, 'UserAdd', 0);
INSERT INTO `role_privileges` VALUES (23, 2, 'UserIndex', 0);
INSERT INTO `role_privileges` VALUES (24, 2, 'UserRoleEdit', 0);
INSERT INTO `role_privileges` VALUES (25, 2, 'UserRoleDelete', 0);
INSERT INTO `role_privileges` VALUES (26, 2, 'ProductAdd', 1);
INSERT INTO `role_privileges` VALUES (27, 2, 'ProductIndex', 1);
INSERT INTO `role_privileges` VALUES (28, 2, 'InventorySendInventorySummary', 0);
INSERT INTO `role_privileges` VALUES (29, 2, 'MenuAdministration', 0);
INSERT INTO `role_privileges` VALUES (30, 2, 'MenuInventory', 1);
INSERT INTO `role_privileges` VALUES (31, 2, 'MenuMaterData', 1);
INSERT INTO `role_privileges` VALUES (32, 2, 'ProductEdit', 1);
INSERT INTO `role_privileges` VALUES (33, 3, 'ProductDelete', 0);
INSERT INTO `role_privileges` VALUES (34, 3, 'UserRoleAdd', 0);
INSERT INTO `role_privileges` VALUES (35, 3, 'UserRoleIndex', 0);
INSERT INTO `role_privileges` VALUES (36, 3, 'UserDelete', 0);
INSERT INTO `role_privileges` VALUES (37, 3, 'UserEdit', 0);
INSERT INTO `role_privileges` VALUES (38, 3, 'UserAdd', 0);
INSERT INTO `role_privileges` VALUES (39, 3, 'UserIndex', 0);
INSERT INTO `role_privileges` VALUES (40, 3, 'UserRoleEdit', 0);
INSERT INTO `role_privileges` VALUES (41, 3, 'UserRoleDelete', 0);
INSERT INTO `role_privileges` VALUES (42, 3, 'ProductAdd', 0);
INSERT INTO `role_privileges` VALUES (43, 3, 'ProductIndex', 1);
INSERT INTO `role_privileges` VALUES (44, 3, 'InventorySendInventorySummary', 0);
INSERT INTO `role_privileges` VALUES (45, 3, 'MenuAdministration', 0);
INSERT INTO `role_privileges` VALUES (46, 3, 'MenuInventory', 0);
INSERT INTO `role_privileges` VALUES (47, 3, 'MenuMaterData', 1);
INSERT INTO `role_privileges` VALUES (48, 3, 'ProductEdit', 0);
INSERT INTO `role_privileges` VALUES (49, 3, 'InventoryUpdateStock', 0);
INSERT INTO `role_privileges` VALUES (50, 2, 'InventoryUpdateStock', 1);
INSERT INTO `role_privileges` VALUES (51, 1, 'InventoryUpdateStock', 0);
INSERT INTO `role_privileges` VALUES (52, 1, 'EmailSendMerchantSummary', 0);
INSERT INTO `role_privileges` VALUES (53, 1, 'Hangfire', 0);
INSERT INTO `role_privileges` VALUES (54, 2, 'EmailSendMerchantSummary', 1);
INSERT INTO `role_privileges` VALUES (55, 2, 'Hangfire', 0);

-- ----------------------------
-- Table structure for user_roles
-- ----------------------------
DROP TABLE IF EXISTS `user_roles`;
CREATE TABLE `user_roles`  (
  `Id` int(0) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsSuperUser` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of user_roles
-- ----------------------------
INSERT INTO `user_roles` VALUES (1, 'Administrator', 1);
INSERT INTO `user_roles` VALUES (2, 'Manager', 0);
INSERT INTO `user_roles` VALUES (3, 'Viewer', 0);

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users`  (
  `Id` int(0) NOT NULL AUTO_INCREMENT,
  `Name` varchar(1000) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PhoneNo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `UserName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `RoleId` int(0) NOT NULL,
  `Active` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`Id`) USING BTREE,
  INDEX `fk_users_RoleId`(`RoleId`) USING BTREE,
  CONSTRAINT `fk_users_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `user_roles` (`Id`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 4 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES (1, 'Administrator', '0712130059', 'prathaptl@gmail.com', 'admin', '6E475092CB912EA2F9258A1E4433D74D', 1, 1);

SET FOREIGN_KEY_CHECKS = 1;
