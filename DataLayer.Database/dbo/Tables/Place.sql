﻿CREATE TABLE [Place] (
  "ID" INT PRIMARY KEY IDENTITY(1,1),
  "Name" VARCHAR(255) NOT NULL,
  "Description" VARCHAR(255) NOT NULL,
  "Type" INT NOT NULL,
  "AverageMark" FLOAT,
  "Latitude" FLOAT,
  "Longitude" FLOAT
);