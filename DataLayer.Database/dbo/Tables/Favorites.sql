CREATE TABLE [Favorites] (
  "ID" INT PRIMARY KEY IDENTITY(1,1),
  "PlaceID" INT NOT NULL,
  "UserID" INT NOT NULL
);
GO
ALTER TABLE "favorites" ADD CONSTRAINT "fk_favorites__place" FOREIGN KEY ("PlaceID") REFERENCES "Place" ("ID");
GO
ALTER TABLE "favorites" ADD CONSTRAINT "fk_favorites__user" FOREIGN KEY ("UserID") REFERENCES "User" ("ID");
GO
CREATE INDEX "idx_favorites__place" ON "Favorites" ("PlaceID");
GO
CREATE INDEX "idx_favorites__user" ON "Favorites" ("UserID");