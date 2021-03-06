﻿CREATE TABLE [Comment] (
  "ID" INT PRIMARY KEY IDENTITY(1,1),
  "PlaceID" INT NOT NULL,
  "Mark" FLOAT NOT NULL,
  "Text" VARCHAR(255) NOT NULL,
  "UserID" INT NOT NULL, 
);
GO
ALTER TABLE "Comment" ADD CONSTRAINT "fk_comment__place" FOREIGN KEY ("PlaceID") REFERENCES "Place" ("ID");
GO
ALTER TABLE "Comment" ADD CONSTRAINT "fk_comment__user" FOREIGN KEY ("UserID") REFERENCES "User" ("ID");