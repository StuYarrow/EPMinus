param ($major, $minor)
$latestBuild = git ls-remote -t -q | `
  ForEach-Object { [Regex]::Match($_, "(\d+)\.(\d+)\.(\d+)") } | `
  Where-Object Success | `
  ForEach-Object { [Version] $_.Value } | `
  Where-Object { $_.Major -eq $major -and $_.Minor -eq $minor } | `
  Sort-Object -Descending | `
  Select-Object -First 1 -ExpandProperty Build
return $latestBuild -eq $null ? 0 : $latestBuild + 1
