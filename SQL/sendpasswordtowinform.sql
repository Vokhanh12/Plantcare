
IF EXISTS(
SELECT 1 FROM dbo.APPLICATION_USER
WHERE UserName = 'khanh1803' AND PWDCOMPARE('Khanh1803@2002',UserPassword)=1)
BEGIN SELECT 'Login Successfully' as 'SYSTEM',TAI_KHOANG FROM dbo.APPLICATION_USER WHERE UserName = 'khanh1803'
END
ELSE
BEGIN SELECT 'Incorrect login attempt.' as 'SYSTEM'
END
