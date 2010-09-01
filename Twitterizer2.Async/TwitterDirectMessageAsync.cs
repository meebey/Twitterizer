﻿using System;
using Twitterizer;

namespace Twitterizer2
{
    public static class TwitterDirectMessageAsync
    {
        /// <summary>
        /// Deletes the specified direct message.
        /// </summary>
        /// <param name="tokens">The tokens.</param>
        /// <param name="id">The direct message id.</param>
        /// <param name="options">The options.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="function">The function.</param>
        /// <returns></returns>
        public static IAsyncResult Delete(OAuthTokens tokens, decimal id, OptionalProperties options, TimeSpan timeout, Action<TwitterResponse<TwitterDirectMessage>> function)
        {
            Func<OAuthTokens, decimal, OptionalProperties, TwitterResponse<TwitterDirectMessage>> methodToCall = TwitterDirectMessage.Delete;

            return methodToCall.BeginInvoke(
                tokens,
                id,
                options,
                result =>
                {
                    result.AsyncWaitHandle.WaitOne(timeout);
                    function(methodToCall.EndInvoke(result));
                },
                null);
        }

        /// <summary>
        /// Returns a list of the 20 most recent direct messages sent by the authenticating user.
        /// </summary>
        /// <param name="tokens">The tokens.</param>
        /// <param name="options">The options.</param>
        /// <returns>
        /// A <see cref="TwitterDirectMessageCollection"/> instance.
        /// </returns>
        public static IAsyncResult DirectMessagesSent(OAuthTokens tokens, DirectMessagesSentOptions options, TimeSpan timeout, Action<TwitterResponse<TwitterDirectMessageCollection>> function)
        {
            Func<OAuthTokens, DirectMessagesSentOptions, TwitterResponse<TwitterDirectMessageCollection>> methodToCall = TwitterDirectMessage.DirectMessagesSent;

            return methodToCall.BeginInvoke(
                tokens,
                options,
                result =>
                {
                    result.AsyncWaitHandle.WaitOne(timeout);
                    function(methodToCall.EndInvoke(result));
                },
                null);
        }

        /// <summary>
        /// Sends a new direct message to the specified user from the authenticating user.
        /// </summary>
        /// <param name="tokens">The tokens.</param>
        /// <param name="userId">The user id.</param>
        /// <param name="text">The text.</param>
        /// <param name="options">The options.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="function">The function.</param>
        /// <returns></returns>
        public static IAsyncResult Send(OAuthTokens tokens, decimal userId, string text, OptionalProperties options, TimeSpan timeout, Action<TwitterResponse<TwitterDirectMessage>> function)
        {
            Func<OAuthTokens, decimal, string, OptionalProperties, TwitterResponse<TwitterDirectMessage>> methodToCall = TwitterDirectMessage.Send;

            return methodToCall.BeginInvoke(
                tokens,
                userId,
                text,
                options,
                result =>
                {
                    result.AsyncWaitHandle.WaitOne(timeout);
                    function(methodToCall.EndInvoke(result));
                },
                null);
        }

        /// <summary>
        /// Sends a new direct message to the specified user from the authenticating user.
        /// </summary>
        /// <param name="tokens">The tokens.</param>
        /// <param name="screenName">The user's screen name.</param>
        /// <param name="text">The text.</param>
        /// <param name="options">The options.</param>
        /// <param name="timeout">The timeout.</param>
        /// <param name="function">The function.</param>
        /// <returns></returns>
        public static IAsyncResult Send(OAuthTokens tokens, string screenName, string text, OptionalProperties options, TimeSpan timeout, Action<TwitterResponse<TwitterDirectMessage>> function)
        {
            Func<OAuthTokens, string, string, OptionalProperties, TwitterResponse<TwitterDirectMessage>> methodToCall = TwitterDirectMessage.Send;

            return methodToCall.BeginInvoke(
                tokens,
                screenName,
                text,
                options,
                result =>
                {
                    result.AsyncWaitHandle.WaitOne(timeout);
                    function(methodToCall.EndInvoke(result));
                },
                null);
        }
    }
}
