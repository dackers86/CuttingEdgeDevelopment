jQuery(function ($) {

    var $slider = $('.slider'); // class or id of carousel slider
    var $slide = 'li'; // could also use 'img' if you're not using a ul
    var $transition_time = 1000; // 1 second
    var $time_between_slides = 4000; // 4 seconds

    var $sliderProgress = $('.slider-Progress'); // class or id of carousel slider

    function slides() {
        return $slider.find($slide);
    }

    function slideProgress() {
        return $sliderProgress.find('li')
    }

    slides().fadeOut();

    // set active classes
    slides().first().addClass('active');
    slides().first().fadeIn($transition_time);
    slideProgress().first().addClass('active');

    // auto scroll 
    $interval = setInterval(
      function () {

          //Slides
          var $i = $slider.find($slide + '.active').index();
          slides().eq($i).removeClass('active');
          slides().eq($i).fadeOut($transition_time);
          slideProgress().eq($i).removeClass('active');
          if (slides().length == $i + 1) $i = -1; // loop to start
          if (slideProgress().length == $i + 1) $i = -1; // loop to start
          slides().eq($i + 1).fadeIn($transition_time);
          slides().eq($i + 1).addClass('active');
          slideProgress().eq($i + 1).addClass('active');

      }
      , $transition_time + $time_between_slides
    );

    $('#flip').jcoverflip();

});




