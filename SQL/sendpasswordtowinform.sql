
IF EXISTS(
SELECT 1 FROM dbo.APPLICATION_USER
WHERE UserName = 'Admin' AND PWDCOMPARE('Admin@123',UserPassword)=1)
BEGIN SELECT 'Login Successfully' as 'SYSTEM',TAI_KHOANG,UserName FROM dbo.APPLICATION_USER WHERE UserName = 'Admin'
END
ELSE
BEGIN SELECT 'Incorrect login attempt.' as 'SYSTEM'
END
