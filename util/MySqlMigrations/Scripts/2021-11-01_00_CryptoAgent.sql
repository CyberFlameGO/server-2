START TRANSACTION;

ALTER TABLE `User` ADD `UsesCryptoAgent` tinyint(1) NOT NULL DEFAULT FALSE;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20211101040328_CryptoAgent', '5.0.9');

COMMIT;
