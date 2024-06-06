// forms js
//  to open the form of create new password 
function openNewPasswordPopup() {
  $('#newPasswordPopup').modal('show');
};



// validation of the login popup

document.addEventListener("DOMContentLoaded", function() {
  const loginForm = document.querySelector('.login_form');

  loginForm.addEventListener('submit', function(event) {
      event.preventDefault(); // Prevent default form submission

      // Get input values
      const username = document.getElementById('log_username').value.trim();
      const password = document.getElementById('log_password').value.trim();

      // Validate input fields
      if (username === '') {
          alert('Please enter your username.');
          return;
      }

      if (password === '') {
          alert('Please enter your password.');
          return;
      }

      // If validation passes, submit the form
      this.submit();
  });
});



// validation for the forgotpassword popup 

document.addEventListener("DOMContentLoaded", function() {
  const forgotPasswordForm = document.getElementById('forgotPasswordForm');

  forgotPasswordForm.addEventListener('submit', function(event) {
      event.preventDefault(); // Prevent default form submission

      // Get input value
      const email = document.getElementById('forgot_email').value.trim();

      // Validate input field
      if (email === '') {
          alert('Please enter your email address.');
          return;
      }

      // If validation passes, submit the form
      this.submit();
  });
});




// validation for new password form  

document.addEventListener("DOMContentLoaded", function() {
  const newPasswordForm = document.getElementById('newPasswordForm');

  newPasswordForm.addEventListener('submit', function(event) {
      event.preventDefault(); // Prevent default form submission

      // Get input values
      const newPassword = document.getElementById('new_password').value.trim();
      const confirmPassword = document.getElementById('confirm_password').value.trim();

      // Validate input fields
      if (newPassword === '') {
          alert('Please enter your new password.');
          return;
      }

      if (confirmPassword === '') {
          alert('Please confirm your new password.');
          return;
      }

      if (newPassword !== confirmPassword) {
          alert('Passwords do not match. Please try again.');
          return;
      }

      // If validation passes, submit the form
      this.submit();
  });
});



// validation for the sign up fprm

document.addEventListener("DOMContentLoaded", function() {
  const registrationForm = document.getElementById('registrationForm');

  registrationForm.addEventListener('submit', function(event) {
      event.preventDefault(); // Prevent default form submission

      // Get input values
      const firstName = document.getElementById('reg_firstName').value.trim();
      const lastName = document.getElementById('reg_lastName').value.trim();
      const email = document.getElementById('reg_email').value.trim();
      const dateOfBirth = document.getElementById('dateOfBirth').value.trim();
      const password = document.getElementById('reg_password').value;
      const confirmPassword = document.getElementById('confirmPassword').value;
      const termsAndConditions = document.getElementById('termsAndConditions').checked;

      // Validate input fields
      if (firstName === '') {
          alert('Please enter your first name.');
          return;
      }

      if (lastName === '') {
          alert('Please enter your last name.');
          return;
      }

      if (email === '') {
          alert('Please enter your email address.');
          return;
      }

      if (dateOfBirth === '') {
          alert('Please select your date of birth.');
          return;
      }

      if (!document.querySelector('input[name="gender"]:checked')) {
          alert('Please select your gender.');
          return;
      }

      if (password === '') {
          alert('Please enter your password.');
          return;
      }

      if (password.length < 8) {
          alert('Password must be at least 8 characters long.');
          return;
      }

      if (password !== confirmPassword) {
          alert('Passwords do not match. Please try again.');
          return;
      }

      if (!termsAndConditions) {
          alert('Please agree to the Terms and Conditions.');
          return;
      }

      // If validation passes, submit the form
      this.submit();
  });
});


// first home section

$(document).ready(function(){
  $('#imageCarousel').carousel({
      interval: 2000 // 2 seconds
  });

  $('#imageCarousel').on('slide.bs.carousel', function () {
      $('.carousel-caption').removeClass('animated').css('transform', 'translateX(-100%)');
  });

  $('#imageCarousel').on('slid.bs.carousel', function () {
      $('.carousel-caption').addClass('animated').css('transform', 'translateX(0)');
  });
});