package huy.java.server;

import java.io.IOException;
import java.io.PrintWriter;

import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.Cookie;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import jakarta.servlet.http.HttpSession;

@WebServlet(urlPatterns = "/targetServlet")
public class targetServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	@Override
	protected void doGet(HttpServletRequest req, HttpServletResponse res) throws IOException {		
        HttpSession session = req.getSession();
        String username = (String) session.getAttribute("username");

        if (username != null) {
            // Attempt to establish a MariaDB connection using the username and password.
            // Replace these values with your actual MariaDB connection code.
            boolean isConnectionSuccessful = establishMariaDBConnection(username);

            if (isConnectionSuccessful) {
                // Inform the user about the successful connection.
                res.getWriter().println("Connection to MariaDB successful for user: " + username);
            } else {
                // Redirect back to the login form with an error message.
                res.sendRedirect("login.html?error=2");
            }
        } else {
            // Redirect back to the login form if the user is not authenticated.
            res.sendRedirect("login.html");
        }
    }
	
	 private boolean establishMariaDBConnection(String username) {
	        return true;
	 }
}