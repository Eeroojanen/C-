package huy.java.server;

import java.io.IOException;
import java.io.PrintWriter;

import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.Cookie;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;

@WebServlet(urlPatterns = "/sourceServlet")
public class sourceServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	
	@Override
	protected void doPost(HttpServletRequest req, HttpServletResponse res) throws ServletException, IOException {
		String userName = req.getParameter("userName");
		String password = req.getParameter("password");
		  
        boolean isValid = validateUser(userName, password);

        if (isValid) {
            HttpSession session = req.getSession();
            session.setAttribute("username", userName);

            // Redirect to the target servlet.
            res.sendRedirect("TargetServlet");
        } else {
            // Redirect back to the login form with an error message.
            res.sendRedirect("login.html?error=1");
        }
    }

    private boolean validateUser(String username, String password) {
        // Implement your database validation logic here.
        // Return true if the user is valid, otherwise false.
        // You should use a database connection to check the user credentials.
        // This is a simplified example and should not be used in production.
        return username.equals("testuser") && password.equals("testpassword");
    }
}
