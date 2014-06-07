param($installPath, $toolsPath, $package, $project)

$project |
	Add-Paths "{
		'scalejs.slider-bxslider' : 'Scripts/scalejs.slider-bxslider-$($package.Version)',
		'bxslider'				  : 'Scripts/jquery.bxslider'
	}" |
	Add-Shims "{ 
		'bxslider'		: { 
			deps : ['jQuery']
		}
	}" | 
	Add-ScalejsExtension 'scalejs.slider-bxslider' |
	Out-Null