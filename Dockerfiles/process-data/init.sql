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
    "BillingAddressId" uuid NOT NULL,
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
VALUES ('20160312183543_RC1', '7.0.0-rc1-16348');CREATE TABLE COMPANY(
   ID INT PRIMARY KEY     NOT NULL,
   NAME           TEXT    NOT NULL,
   AGE            INT     NOT NULL,
   ADDRESS        CHAR(50),
   SALARY         REAL
);
