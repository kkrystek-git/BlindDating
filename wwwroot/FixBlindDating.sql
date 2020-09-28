
Use BlindDating;
UPDATE DatingProfile SET User_AccountId='293b6699-a783-4a6a-a662-a36155f5b8f3' WHERE ID=1;
UPDATE DatingProfile SET firstname='Test Firstname1', lastname='Test Lastname1' WHERE ID=1;
UPDATE DatingProfile SET User_AccountId='2f93b3b6-a5f8-40d1-97eb-a3a90aeaea11' WHERE ID=3;
DELETE FROM DatingProfile WHERE ID=2;
INSERT INTO AspNetUserRoles VALUES ('293b6699-a783-4a6a-a662-a36155f5b8f3', '430f1686-1a03-4856-9f1b-86152405266a');
UPDATE AspNetUserRoles SET RoleId='5d3ab6fe-da03-49ac-840d-e6f64a88f231' WHERE UserId='293b6699-a783-4a6a-a662-a36155f5b8f3';
GO

Use BlindDating;
Select * from AspNetUsers;
Select * from AspNetRoles;
Select * from AspNetUserRoles;
Select * from DatingProfile;
GO
