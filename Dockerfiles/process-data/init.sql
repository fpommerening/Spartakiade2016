CREATE TABLE "__EFMigrationsHistory" (
    "MigrationId" text NOT NULL,
    "ProductVersion" text NOT NULL,
    CONSTRAINT "PK_HistoryRow" PRIMARY KEY ("MigrationId")
);

CREATE TABLE "Address" (
    "Id" uuid NOT NULL,
    "City" text NOT NULL,
    "Country" text,
    "Number" text NOT NULL,
    "Street" text NOT NULL,
    "ZipCode" text NOT NULL,
    CONSTRAINT "PK_Address" PRIMARY KEY ("Id")
);

CREATE TABLE "Customer" (
    "Id" uuid NOT NULL,
    "BillingAddressId" uuid NULL,
    "Birthday" timestamp NOT NULL,
    "DeliveryAddressId" uuid NOT NULL,
    "Email" text NOT NULL,
    "FirstName" text NOT NULL,
    "Name" text NOT NULL,
    "Number" text NOT NULL,
    "Title" text,
    CONSTRAINT "PK_Customer" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Customer_Address_BillingAddressId" FOREIGN KEY ("BillingAddressId") REFERENCES "Address" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Customer_Address_DeliveryAddressId" FOREIGN KEY ("DeliveryAddressId") REFERENCES "Address" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Bill" (
    "Id" uuid NOT NULL,
    "AddressId" uuid NOT NULL,
    "Customerid" uuid NOT NULL,
    "DocumentDate" timestamp NOT NULL,
    "Number" text NOT NULL,
    CONSTRAINT "PK_Bill" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Bill_Address_AddressId" FOREIGN KEY ("AddressId") REFERENCES "Address" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Bill_Customer_Customerid" FOREIGN KEY ("Customerid") REFERENCES "Customer" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Position" (
    "Id" uuid NOT NULL,
    "Article" text NOT NULL,
    "BillId" uuid NOT NULL,
    "Comment" text,
    "GrossAmmount" numeric NOT NULL,
    "NetAmount" numeric NOT NULL,
    "Number" int4 NOT NULL,
    "TaxAmmount" numeric NOT NULL,
    "ValidFrom" timestamp NOT NULL,
    "ValidTo" timestamp NOT NULL,
    CONSTRAINT "PK_Position" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Position_Bill_BillId" FOREIGN KEY ("BillId") REFERENCES "Bill" ("Id") ON DELETE CASCADE
);

CREATE TABLE "Reversal" (
    "Id" uuid NOT NULL,
    "DocumentDate" timestamp NOT NULL,
    "Number" text NOT NULL,
    "ReferenceBillId" uuid NOT NULL,
    CONSTRAINT "PK_Reversal" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_Reversal_Bill_ReferenceBillId" FOREIGN KEY ("ReferenceBillId") REFERENCES "Bill" ("Id") ON DELETE CASCADE
);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20160312183543_RC1', '7.0.0-rc1-16348');

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20160312193957_rc2', '7.0.0-rc1-16348');


INSERT INTO "Address" ("Id","City","Country","Number","Street","ZipCode")
					VALUES ('ad450150-fa37-4848-866f-57fee767df29','Göritz',NULL,'41c','Wiener Platz','02826');

INSERT INTO "Address" ("Id","City","Country","Number","Street","ZipCode")
					VALUES ('23e77993-a965-4064-adf6-a543bfee5901','Sebnitz',NULL,'12','Zum Wolfsberg','01855');

INSERT INTO "Address" ("Id","City","Country","Number","Street","ZipCode")
					VALUES ('7518da51-3d4a-4f93-9204-3e777a431c37','Dresden',NULL,'20','Maxener Straße','01139');

INSERT INTO "Address" ("Id","City","Country","Number","Street","ZipCode")
					VALUES ('d3dc385c-5f42-465d-be0d-46ccb55dc94f','Dresden',NULL,'99','Sternstraße','01099');

INSERT INTO "Address" ("Id","City","Country","Number","Street","ZipCode")
					VALUES ('f24c6846-1c6b-42aa-b8e6-c14f6cd4797b','Leipzig',NULL,'34a','Hauptstraße','04347');

INSERT INTO "Customer" ("Id","Birthday","DeliveryAddressId","Email","FirstName","Name","Number","Title")
					VALUES ('5847b937-78c4-4001-becb-7d4ce2b584f0','1962-09-15', 'ad450150-fa37-4848-866f-57fee767df29', 'jürgen.meier@beispiel.de','Jürgen','Meier','K-000001','Herr');

INSERT INTO "Customer" ("Id","Birthday","DeliveryAddressId","Email","FirstName","Name","Number","Title")
					VALUES ('eca61858-871b-4db2-94a4-dfea0af34ff8','1971-12-06', '23e77993-a965-4064-adf6-a543bfee5901', 'wolfgang.kaufmann@beispiel.de','Wolfgang','Kaufmann','K-000002','Herr');

INSERT INTO "Customer" ("Id","Birthday","DeliveryAddressId","BillingAddressId","Email","FirstName","Name","Number","Title")
					VALUES ('4e0e4549-34fd-4a1f-ae3c-af04da6a1fc2','1951-01-06', 'd3dc385c-5f42-465d-be0d-46ccb55dc94f', '7518da51-3d4a-4f93-9204-3e777a431c37', 'sabine.muellerbeispiel.de','Sabine','Müller','K-000003','Frau');


INSERT INTO "Customer" ("Id","Birthday","DeliveryAddressId","Email","FirstName","Name","Number","Title")
					VALUES ('3f8093e3-3f52-42c7-b6c8-9ce941597f2f','1990-07-06', 'f24c6846-1c6b-42aa-b8e6-c14f6cd4797b', 'Kevin.Lehmann@beispiel.de','Kevin','Lehmann','K-000004','Herr');


INSERT INTO "Address" ("Id","City","Country","Number","Street","ZipCode")
					VALUES ('c60c9898-37f1-419f-b7e2-e72f4f2ad85a','Leipzig',NULL,'34a','Hauptstraße','04347');

INSERT INTO "Bill" ("Id","AddressId","Customerid","DocumentDate","Number")
					VALUES ('7e5f4c08-f7cb-49f2-a8f4-c90fb015640d','c60c9898-37f1-419f-b7e2-e72f4f2ad85a','3f8093e3-3f52-42c7-b6c8-9ce941597f2f','2015-02-02','R-000001');

INSERT INTO "Position" ("Id","Article","BillId","GrossAmmount","NetAmount","Number","TaxAmmount","ValidFrom","ValidTo")
VALUES ('4dd270d1-444b-48c1-9c3d-99dc711182e4','Grundgebühr','7e5f4c08-f7cb-49f2-a8f4-c90fb015640d','100','119','1','19','2015-01-01','2015-01-31');


INSERT INTO "Address" ("Id","City","Country","Number","Street","ZipCode")
					VALUES ('bb149f4d-55a7-484d-9ef5-e983772546e6','Leipzig',NULL,'34a','Hauptstraße','04347');

INSERT INTO "Bill" ("Id","AddressId","Customerid","DocumentDate","Number")
					VALUES ('488a2d7c-ca64-4bda-9380-6f021feeb1ef','bb149f4d-55a7-484d-9ef5-e983772546e6','3f8093e3-3f52-42c7-b6c8-9ce941597f2f','2015-03-02','R-000002');

INSERT INTO "Position" ("Id","Article","BillId","GrossAmmount","NetAmount","Number","TaxAmmount","ValidFrom","ValidTo")
VALUES ('295a6751-1276-43a0-8d07-b94ca9796dcb','Grundgebühr','488a2d7c-ca64-4bda-9380-6f021feeb1ef','100','119','1','19','2015-02-01','2015-02-28');

INSERT INTO "Address" ("Id","City","Country","Number","Street","ZipCode")
					VALUES ('85825d41-c0fa-4600-83d3-06f3c9e2526c','Leipzig',NULL,'34a','Hauptstraße','04347');

INSERT INTO "Bill" ("Id","AddressId","Customerid","DocumentDate","Number")
					VALUES ('f77d85e0-e295-4d98-96fb-8a9a5a9117c8','85825d41-c0fa-4600-83d3-06f3c9e2526c','3f8093e3-3f52-42c7-b6c8-9ce941597f2f','2015-04-02','R-000003');

INSERT INTO "Position" ("Id","Article","BillId","GrossAmmount","NetAmount","Number","TaxAmmount","ValidFrom","ValidTo")
VALUES ('93a3ecac-63cb-4826-b1ba-951d16bb3700','Grundgebühr','f77d85e0-e295-4d98-96fb-8a9a5a9117c8','100','119','1','19','2015-03-01','2015-03-31');

