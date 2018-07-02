var count = 0;
var number = 1;

$(document).ready(function ()
{
    function nextShow()
    {        
        var last = number;
        
        number++;
        if (number > count)
            number = 1;
        
        $('#banner' + number).css('z-index', '0');
        $('#banner' + number).show();        
        $('#banner' + last).fadeOut(1000, function()
        {
            $('#banner' + number).css('z-index', '1');
        });    
        
        setTimeout(nextShow, 6000);
    }
    
    $('.top-block').find('.banner').each(function() 
    {
        $(this).css('display', 'none');
        count++;
    })
    
    if(count > 0)
    {
        $('#banner' + number).css('z-index', '1');
        $('#banner' + number).show();
        if(count > 1)
            setTimeout(nextShow, 6000);
    }
});