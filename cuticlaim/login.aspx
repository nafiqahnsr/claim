<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="cuticlaim.login" %>

<!DOCTYPE html>

<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="Mark Otto, Jacob Thornton, and Bootstrap contributors">
    <meta name="generator" content="Jekyll v3.8.5">
    <title>Signin Template · Bootstrap</title>

    <link rel="canonical" href="https://getbootstrap.com/docs/4.3/examples/sign-in/">

    <!-- Bootstrap core CSS -->
      <link href="css/main.css" rel="stylesheet" />
      <link href="css/util.css" rel="stylesheet" />

    <style>
      .bd-placeholder-img {
        font-size: 1.125rem;
        text-anchor: middle;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
      }

      @media (min-width: 768px) {
        .bd-placeholder-img-lg {
          font-size: 3.5rem;
        }
      }
    </style>
    <!-- Custom styles for this template -->
      <link href="css/signin.css" rel="stylesheet" />

  </head>
  <body>
      <div class="limiter">
		    <div class="container-login100" style="background-image: url('images/bg-01.jpg');">
			    <div class="wrap-login100">
				    <form class="login100-form validate-form">
					    <span class="login100-form-logo">
						    <%--<i class="zmdi zmdi-landscape"></i>--%>
                            <img src="images/logo2.png" width="80px"/>
					    </span>

					    <span class="login100-form-title p-b-34 p-t-27">
						    Mindwave Consultancy
					    </span>

					    <div class="wrap-input100 validate-input" data-validate = "Enter username">
						    <input class="input100" type="text" name="inputUser" placeholder="Username">
						    <%--<span class="focus-input100" data-placeholder="&#xf207;"></span>--%>
					    </div>

					    <div class="wrap-input100 validate-input" data-validate="Enter password">
						    <input class="input100" type="password" name="inputPassword" placeholder="Password">
						    <%--<span class="focus-input100" data-placeholder="&#xf191;"></span>--%>
					    </div>

					    <div class="container-login100-form-btn" >
						    <button class="login100-form-btn">
							    login
						    </button>
					    </div>
				    </form>
			    </div>
		    </div>
	    </div>
      </body>
</html>