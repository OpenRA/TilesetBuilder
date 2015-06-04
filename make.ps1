function FindMSBuild
{
	$msBuildVersions = @("4.0")
	foreach ($msBuildVersion in $msBuildVersions)
	{
		$key = "HKLM:\SOFTWARE\Microsoft\MSBuild\ToolsVersions\{0}" -f $msBuildVersion
		$property = Get-ItemProperty $key -ErrorAction SilentlyContinue
		if ($property -eq $null -or $property.MSBuildToolsPath -eq $null)
		{
			continue
		}
		$path = Join-Path $property.MSBuildToolsPath -ChildPath "MSBuild.exe"
		if (Test-Path $path)
		{
			return $path
		}
	}
	return $null
}

$msBuild = FindMSBuild
$msBuildArguments = "/t:Rebuild /nr:false"
if ($msBuild -eq $null)
{
	echo "Unable to locate an appropriate version of MSBuild."
}
else
{
	$proc = Start-Process $msBuild $msBuildArguments -NoNewWindow -PassThru -Wait
	if ($proc.ExitCode -ne 0)
	{
		echo "Build failed."
	}
	else
	{
		echo "Build succeeded."
	}
}