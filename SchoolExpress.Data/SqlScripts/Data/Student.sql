DELETE FROM Student
DBCC CHECKIDENT ('[Student]', RESEED, 0);
GO
SET IDENTITY_INSERT Student ON
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(1, 24, 'UO220200', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(2, 25, 'UO221371', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(3, 26, 'UO225476', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(4, 27, 'UO218844', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(5, 28, 'UO224798', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(6, 29, 'UO223346', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(7, 31, 'UO218540', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(8, 32, 'UO226757', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(9, 33, 'UO226784', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(10, 34, 'UO217327', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(11, 35, 'UO226310', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(12, 36, 'UO224862', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(13, 37, 'UO217358', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(14, 38, 'UO225962', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(15, 39, 'UO226448', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(16, 40, 'UO217103', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(17, 41, 'UO224395', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(18, 42, 'UO218684', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(19, 43, 'UO201985', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(20, 44, 'UO213311', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(21, 45, 'UO224962', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(22, 46, 'UO216778', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(23, 47, 'UO218186', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(24, 48, 'UO225964', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(25, 49, 'UO226438', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(26, 50, 'UO218115', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(27, 51, 'UO213175', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(28, 52, 'UO217690', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(29, 53, 'UO208670', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(30, 54, 'UO218730', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(31, 55, 'UO212469', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(32, 56, 'UO219344', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(33, 57, 'UO204336', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(34, 58, 'UO13346', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(35, 59, 'UO217527', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(36, 60, 'UO50725', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(37, 61, 'UO218256', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(38, 62, 'UO219037', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(39, 63, 'UO210010', GETDATE(), GETDATE(), 1)
insert into Student (Id, PersonId, SubscriptionId, LastModified, Created, Status) values(40, 64, 'UO225895', GETDATE(), GETDATE(), 1)
SET IDENTITY_INSERT Student OFF