param($installPath, $toolsPath, $package, $project)

$project |
	Remove-Paths 'scalejs.slider-bxslider' |
	Remove-Shims 'bxslider' |
	Remove-ScalejsExtension 'scalejs.slider-bxslider' |
	Out-Null
