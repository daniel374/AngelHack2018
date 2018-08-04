Router.configure({
    layoutTemplate: 'layout',
    notFoundTemplate: 'notFound'
});

//
// Dashboard route
//

Router.route('/', function () {
    Router.go('main');
});

Router.route('/main', function () {
    this.render('main');
});

Router.route('/page2', function () {
    this.render('page2');
});



//
// Global - Remove splash screen after after rendered layout
//

Router.onAfterAction(function()
{
    setTimeout(function()
    {
        $('.splash').css('display', 'none')
    })
});