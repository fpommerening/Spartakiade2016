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
    "AddessId" uuid NOT NULL,
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

