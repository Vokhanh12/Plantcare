SELECT * FROM dbo.DATA_APPLICATION_FOR_ADMIN
IF EXISTS(
SELECT 1 FROM dbo.DATA_APPLICATION_FOR_ADMIN
WHERE UserName ='Admin'
AND PWDCOMPARE('Admin@123',UserPassword)=1)
BEGIN
SELECT 'Login Successfully' as 'Login Successfully Using PWDCOMPARE'
END
ELSE
BEGIN SELECT 'Incorrect login attempt.' as 'While passing PWDCOMPARE function'
END
